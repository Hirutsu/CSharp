using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(@"I:\git\CSharp\Graphs\Graphs\input.txt");
            //graph.Show();
            //graph.FindNeighboringPeaks(0);
            //graph.FindAllAreAchievable();
            for(int index=0;index <graph.Size(); index++) 
            {
                for(int Jindex=0;Jindex<graph.Size();Jindex++)
                {
                    if (index != Jindex)
                    {
                        if (graph.Floyd(30, index, Jindex))
                        {
                            Console.WriteLine("При удаление дороги из вершины " + index + " в вершину " + Jindex + ". Все пути будут <N");
                        }
                        else
                        {
                            Console.WriteLine("При удаление дороги из вершины {0} в вершину {1}.Условие не выполняется", index, Jindex);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            //graph.Floyd(30);
        }
    }
}
