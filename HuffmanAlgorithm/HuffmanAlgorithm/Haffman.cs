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
            public char key;
            public Node left;
            public Node right;

            public Node(int a)
            {
                inf = a;
                left = null;
                right = null;
                key = '\0';
            }

            public Node(KeyValuePair<char, int> a)
            {
                inf = a.Value;
                left = null;
                right = null;
                key = a.Key;
            }

            public Node(Node firstNode, Node secondNode)
            {
                Node node = new Node((int)firstNode.inf + (int)secondNode.inf);
                node.left = firstNode;
                node.right = secondNode;
            }
        }

        Node tree;
        List<Node> nodes;
        public Haffman(Dictionary<char,int> dic) 
        {
            nodes = new List<Node>();
            foreach(KeyValuePair<char,int> item in dic.OrderBy(key => key.Value))
            {
                Node node = new Node(item);
                nodes.Add(node);
            }
            CreateHaffmanTree();
        }

        public void CreateHaffmanTree()
        {
            if(nodes.Count == 1)
            {
                tree = nodes[0];
            }
            else
            {
                Node created = new Node(nodes[0], nodes[1]);
                nodes.RemoveAt(0);
                nodes.RemoveAt(1);
                nodes.Add(created);
                nodes.Sort();
                CreateHaffmanTree();
            }
        }
    }
}
