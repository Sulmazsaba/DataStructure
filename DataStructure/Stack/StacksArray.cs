using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class StacksArray
    {
        private int[] data;
        private int top;

        public StacksArray(int n)
        {
            data = new int[n];
            top = 0;
        }

        public int Length()
        {
            return top;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == data.Length;
        }

        public void Push(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
                return;

            }
            else
            {
                data[top] = element;
                top++;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                var element = data[top - 1];
                top--;
                return element;
            }
        }

        public string Display()
        {
            var result = "";
            for (int i = 0; i < top; i++)
            {
                result += $"{data[i]}=>";
            }

           return result;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            return data[top - 1];

        }

    }
}
