using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\offic\source\repos\PracticeCSharp\PracticeCSharp\TextFile1.txt", false))
            {
                string allText = streamReader.ReadToEnd();
                words = allText.Split();
            }
            BinaryTree binaryTree = new BinaryTree();
            for(int index = 0; index < words.Length;index++)
            {
                binaryTree.Add(Convert.ToInt32(words[index]));
            }
            //Подсчет суммы через прямой проход
            Console.WriteLine(binaryTree.SumOddNums());
            Console.WriteLine(binaryTree.SumEvenNums());
            Console.WriteLine("Last element(самый глубокий):" + binaryTree.SearchDepthNode(250));
            Console.WriteLine("Глубина корня:"+ binaryTree.SearchDepthNode(5));
            Console.WriteLine("Глубина потомка корня:" + binaryTree.SearchDepthNode(-2));
        }
    }
}
