using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanAlgorithm
{
        public class Haffman
        {
            private class Node
            {
                public object inf;
                public int number;
                public int weight;
                public Node left;
                public Node rigth;

                public Node(object nodeInf) //конструктор вложенного класса, создает узел дерева
                {
                    inf = nodeInf;
                    number = 0;
                    weight = 0;
                    left = null;
                    rigth = null;
                }

                public static void Add(ref Node r, int weight)
                {
                    Dictionary<Node,int> list = new Dictionary<Node, int>();
                    
                }    
            }
            Node tree;

            public Haffman()//открытый конструктор
            {
                tree = null;
            }
            private Haffman(Node r)
            {
                tree = r;
            }
            public void Add(Dictionary<char, int> tempDic)
            {
                Node.Add();
            }
    }
}
