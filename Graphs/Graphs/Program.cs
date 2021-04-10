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
            graph.Show();
            graph.FindNeighboringPeaks(0);
        }
    }
}
