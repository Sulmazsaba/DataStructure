using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queues
{
    public class QueuesArray
    {
        private int[] data;
        private int rear;
        public int front;
        private int size;


        public QueuesArray(int n)
        {
            data = new int[n];
            rear = 0;
            front = 0;
            size = 0;
        }

        public int Length() => size;
        public bool IsFull() => size == data.Length;

        public bool IsEmpty() => size == 0;

        public void Enqueue(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            else
            {
                data[rear] = element;
                rear++;
                size++;
            }

        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the Queue is empty");
                return -1;
            }
            else
            {
                var element = data[front];
                front++;
                size--;
                return element;
            }
        }

        public int First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the Queue is empty");
                return -1;
            }
            else
            {
                return data[front];
            }

        }


        public void Display()
        {
            for (int i = front; i < rear; i++)
            {
                Console.Write(data[i] + "-->");
            }

            Console.WriteLine();
        }
    }
}
