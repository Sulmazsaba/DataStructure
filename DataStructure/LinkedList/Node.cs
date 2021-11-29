using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;

        }
    }
}
