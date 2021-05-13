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
    public class Product_DAO : Product_DAO_Interface
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

        public IEnumerable<Product> DeleteAll()
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteAll";
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

        public void DeleteProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteProduct";
                cmd.Parameters.AddWithValue(@"id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
           
        }
        public void UpdateProduct(int id, string Name, double Price, int Sale, DateTime? StartSale,DateTime? EndSale)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProduct";
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
        public IEnumerable<Product> SearchByName(string Name)
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByName";
                cmd.Parameters.AddWithValue(@"name", Name);
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
                if(products.Count==0)
                {
                    MessageBox.Show("Данных товаров не найдено");
                }
            }
            return products;
        }
        public IEnumerable<Product> SearchByPrice(double Price)
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByPrice";
                cmd.Parameters.AddWithValue(@"price", Price);
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
                if (products.Count == 0)
                {
                    MessageBox.Show("Данных товаров не найдено");
                }
            }
            return products;
        }
        public IEnumerable<Product> SearchBySale(int Sale)
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchBySale";
                cmd.Parameters.AddWithValue(@"sale", Sale);
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
                if (products.Count == 0)
                {
                    MessageBox.Show("Данных товаров не найдено");
                }
            }
            return products;
        }
        public IEnumerable<Product> SearchByDateSale(DateTime dateSale)
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByDateSale";
                cmd.Parameters.AddWithValue(@"dateSale", dateSale);
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
                if (products.Count == 0)
                {
                    MessageBox.Show("Данных товаров не найдено");
                }
            }
            return products;
        }
    }
}
