﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList.DoublyLinkedList
{
   public class Node
    {
        public int Element { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int element, Node next, Node prev)
        {
            Element = element;
            Next = next;
            Prev = prev;
        }
    }
}
