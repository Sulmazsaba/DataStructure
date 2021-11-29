using System;

namespace DataStructure.LinkedList.CircularLinkedList
{
    public class CircularLinkedList
    {

        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
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
            var newest = new Node(element, null);

            if (IsEmpty())
            {
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }


            tail = newest;
            size++;
        }

        public void Display()
        {
            var p = head;
            int i = 0;
            while (i < Length())
            {
                Console.Write($"{p.element} --> ");
                p = p.next;
                i++;
            }

            Console.WriteLine();
        }
    }
}
