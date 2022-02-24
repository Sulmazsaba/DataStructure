using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queues
{
    public class QueuesStacks
    {

        public Stack<int> stackForEnqueue = new Stack<int>();
        public Stack<int> stackForDequeue = new Stack<int>();

        public void Enqueue(int item)
        {
            while (stackForEnqueue.Count > 0)
            {
                stackForDequeue.Push(stackForEnqueue.Pop());
            }

            stackForEnqueue.Push(item);

            while (stackForDequeue.Count > 0)
            {
                stackForEnqueue.Push(stackForDequeue.Pop());
            }

        }

        public int Dequeue()
        {
            if (stackForEnqueue.Count == 0) return -1;
            return stackForEnqueue.Pop();
        }

        public string Display()
        {
            var result = new StringBuilder();

            foreach (var item in stackForEnqueue)
            {
                result.Append(item + "=>");
            }

            return result.ToString();
        }


        public void Reverse()
        {
            while (stackForEnqueue.Count > 0)
            {
                stackForDequeue.Push(stackForEnqueue.Pop());
            }

            stackForEnqueue = stackForDequeue;
        }

    }
}
