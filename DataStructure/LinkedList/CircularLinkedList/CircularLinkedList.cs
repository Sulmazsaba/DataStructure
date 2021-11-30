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

        public void AddFirst(int element)
        {
            var newest = new Node(element, null);
            if (IsEmpty())
            {
                newest.next = newest;
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                tail.next = newest;
                head = newest;
            }

            size++;
        }

        public void AddAny(int element, int position)
        {
            if (position < 0 || position > size)
            {
                Console.WriteLine("Position is invalid");
                return;
            }
            else
            {
                var newest = new Node(element, null);
                var p = head;
                var i = 1;
                while (i < position - 1)
                {
                    p = p.next;
                    i++;
                }

                newest.next = p.next;
                p.next = newest;

                size++;


            }
        }

        public int RemoveFirst()
        {
            var p = head;
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is Empty");
                return -1;
            }

            var element = head.element;
            tail.next = head.next;
            head = head.next;
            size--;
            if (IsEmpty())
            {
                tail = null;
                head = null;
            }
            return element;
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is Empty");
                return -1;
            }

            var p = head;
            var index = 1;
            while (index < size - 1)
            {
                p = p.next;
                index++;
            }

            var element = p.next.element;
            p.next = head;
            tail = p;
            size--;

            return element;

        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("invalid position");
                return -1;
            }

            var p = head;
            var index = 1;
            while (index < position - 1)
            {
                p = p.next;
                index++;
            }

            var element = p.next.element;
            p.next = p.next.next;

            size--;
            return element;
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
