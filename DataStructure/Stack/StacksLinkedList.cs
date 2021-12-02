using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.LinkedList;

namespace DataStructure.Stack
{
    public class StacksLinkedList
    {

        private Node top;
        private int size;

        public StacksLinkedList()
        {
            top = null;
            size = 0;
        }
        public int Length()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void Push(int element)
        {
            var newest = new Node(element, null);
            if (IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }

            size++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            var element = top.element;
            top = top.next;

            size--;
            return element;
        }

        public int Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            return top.element;
        }
        public void Display()
        {
            Node p = top;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();

        }
    }
}
