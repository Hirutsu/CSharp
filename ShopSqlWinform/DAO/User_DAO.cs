using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_User;
using DAO_Interface;

namespace DAO
{
    public class User_DAO : User_DAO_Interface
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public void Add(Product value)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddProduct";
                cmd.Parameters.AddWithValue(@"name", value.Name);
                cmd.Parameters.AddWithValue(@"price", value.Price);
                cmd.Parameters.AddWithValue(@"sale", value.Sale);
                cmd.Parameters.AddWithValue(@"saleStart", value.StartSale);
                cmd.Parameters.AddWithValue(@"saleEnd", value.EndSale);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "id",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }
        public IEnumerable<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetListProduct";
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["name"],
                        Price = (double)reader["price"],
                        Sale = (int)reader["sale"],
                        StartSale = (DateTime)reader["saleStart"],
                        EndSale = (DateTime)reader["saleEnd"]
                    });
                }
            }
            return products;
        }

        public void Remove(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveProduct";
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();

               
                cmd.ExecuteNonQuery();
            }
           
        }

        public Product GetInfoProduct(int id)
        {
            Product product = new Product();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetINFO_Product";
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    product = (new Product
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["name"],
                        Price = (double)reader["price"],
                        Sale = (int)reader["sale"],
                        StartSale = (DateTime)reader["saleEnd"],
                        EndSale = (DateTime)reader["saleEnd"]
                    });
                }
            }
            return product;
        }
        public void UpdateProduct(int id, string Name, double Price, int Sale, DateTime? StartSale,DateTime? EndSale)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUser";
                cmd.Parameters.AddWithValue(@"id", id);
                cmd.Parameters.AddWithValue(@"name", Name);
                cmd.Parameters.AddWithValue(@"price", Price);
                cmd.Parameters.AddWithValue(@"sale", Sale);
                cmd.Parameters.AddWithValue(@"saleStart", StartSale);
                cmd.Parameters.AddWithValue(@"saleEnd", EndSale);
                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
