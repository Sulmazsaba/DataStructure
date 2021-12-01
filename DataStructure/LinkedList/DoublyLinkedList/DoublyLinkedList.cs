using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
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
        public void AddLast(int element)
        {
            var newest = new Node(element, null, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;

            }
            else
            {
                tail.Next = newest;
                newest.Prev = tail;
                tail = newest;

            }

            size++;

        }

        public void AddFirst(int element)
        {
            var newest = new Node(element, null, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;

            }
            else
            {
                newest.Next = head;
                head.Prev = newest;
                head = newest;
            }

            size++;

        }

        public void Display()
        {
            var p = head;
            while (p != null)
            {
                Console.Write($"{p.Element} ==>");
                p = p.Next;
            }
            Console.WriteLine();
        }
    }
}
