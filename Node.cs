using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public class Node
    {
        private Tuple<String, int> number;
        public Node rightLeaf;
        public Node leftLeaf;

        public Node(Tuple<String, int> value)
        {
            number = value;
            rightLeaf = null;
            leftLeaf = null;
        }

        public bool isLeaf(ref Node node)
        {
            return (node.rightLeaf == null && node.leftLeaf == null);

        }

        public void insertData(ref Node node, Tuple<String, int> data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.number.Item2 < data.Item2)
            {
                insertData(ref node.rightLeaf, data);
            }

            else
            {
                insertData(ref node.leftLeaf, data);
            }
        }
        public void oorchil(Tuple<String, int> a)
        {
            number = a;
        }
        public Tuple<String, int> hus()
        {
            return number;
        }
    }

}
