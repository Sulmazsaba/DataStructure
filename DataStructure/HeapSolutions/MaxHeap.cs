using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HeapSolutions
{
    public class MaxHeap
    {
        public static void Heapify(int[] numbers)
        {
            var startIndex = (numbers.Length / 2) - 1;
            for (int i = startIndex; i >= 0; i--)
            {
                Heapify(numbers, i);
            }

        }

        private static void Heapify(int[] numbers, int index)
        {
            var largerIndex = index;
            var leftChildIndex = (index * 2) + 1;
            //compare to left child
            if (leftChildIndex < numbers.Length && numbers[leftChildIndex] > numbers[largerIndex])
            {
                largerIndex = leftChildIndex;
            }

            var rightChildIndex = (index * 2) + 2;
            //compare to right child
            if (rightChildIndex < numbers.Length && numbers[rightChildIndex] > numbers[largerIndex])
            {
                largerIndex = rightChildIndex;
            }

            if (index == largerIndex)
                return;

            Swap(numbers, index, largerIndex);

            Heapify(numbers, largerIndex);
        }

        private static void Swap(int[] numbers, int first, int second) => (numbers[first], numbers[second]) = (numbers[second], numbers[first]);

        public static int GetKthLargest(int[] array, int k)
        {
            if (k < 0 || k > array.Length)
                throw new InvalidOperationException();
            var heap = new Heap();
            foreach (var i in array)
            {
                heap.Insert(i);
            }

            for (int i = 0; i < k - 1; i++)
            {
                heap.Remove();
            }

            return heap.Max();
        }


    }
}
