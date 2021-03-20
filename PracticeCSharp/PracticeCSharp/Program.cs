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
            int[] mas = { 6, 5, 4, 3, 2,1 };
            int temp;
            int elem = 0;
            for(int i=0;i<mas.Length;i++)
            {
                for(int j=0;j<mas.Length-1;j++)
                {
                    if(mas[j]>mas[j+1])
                    {
                        temp = mas[j+1];
                        mas[j+1] = mas[j];
                        mas[j] = temp;
                    }
                    elem++;
                    Console.Write(elem + ")");
                    for(int index=0;index<mas.Length;index++)
                    {
                        Console.Write(mas[index]+" ");
                    }
                    Console.WriteLine();
                }
            }
            for(int i =0;i<mas.Length;i++)
            {
                Console.WriteLine(mas[i] + " ");
            }
        }
    }
}
