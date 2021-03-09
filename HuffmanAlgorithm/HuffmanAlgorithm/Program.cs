using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HuffmanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();//аук32432ква324 и23
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int index =0;index<str.Length;index++)
            {
                if(dic.ContainsKey(str[index]))
                {
                    dic[str[index]]++;
                }
                else
                {
                    dic.Add(str[index], 1);
                }
            }
            foreach(var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Haffman tree = new Haffman(dic);
        }
    }
}
