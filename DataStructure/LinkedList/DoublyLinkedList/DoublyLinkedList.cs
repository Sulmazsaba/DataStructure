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

        public void AddAny(int element, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.Write("Position is not Valid");
                return;
            }

            var newest = new Node(element, null, null);
            var p = head;
            var i = 1;
            while (i < position - 1)
            {
                p = p.Next;
                i++;
            }

            newest.Next = p.Next;
            p.Next.Prev = newest;
            newest.Prev = p;
            p.Next = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.Write("list is empty");
                return -1;
            }

            var e = head.Element;
            head = head.Next;
            size--;

            if (IsEmpty())
                tail = null;
            else
            {

                head.Prev = null;
            }


            return e;

        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("list is empty");
                return -1;
            }

            var element = tail.Element;
            tail = tail.Prev;
            tail.Next = null;

            size--;
            return element;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("position is not correct");
                return -1;
            }

            var p = head;
            var index = 1;

            while (index < position - 1)
            {
                p = p.Next;
                index++;
            }

            var element = p.Next.Element;
            p.Next = p.Next.Next;
            p.Next.Prev = p;

            size--;
            return element;
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
