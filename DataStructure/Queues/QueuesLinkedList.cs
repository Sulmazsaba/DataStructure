using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.LinkedList;

namespace DataStructure.Queues
{
    public class QueuesLinkedList
    {
        private Node front;
        private Node rear;
        private int size;

        public QueuesLinkedList()
        {
            rear = null;
            front = null;
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
        public void Enqueue(int element)
        {
            var newest = new Node(element, null);
            if (IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }

            rear = newest;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }

            var element = front.element;
            front = front.next;

            size--;
            if (IsEmpty())
            {
                rear = null;
            }
            return element;
        }

        public string Display()
        {
            var result = new StringBuilder();
            Node p = front;
            while (p != null)
            {
                result.Append(p.element + "=>");
                p = p.next;
            }
            return result.ToString();
        }

        public int First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }

            return front.element;
        }
    }
}
