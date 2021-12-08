using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HeapSolutions
{
    public class Heap
    {
        private int size = 0;
        private int[] items = new int[10];

        public void Insert(int value)
        {
            if (IsFull)
                throw new InvalidOperationException();
            items[size++] = value;
            BubbleUp();
        }

        public void Remove()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            items[0] = items[--size];

            BubbleDown();
        }

        private void BubbleUp()
        {
            var index = size - 1;

            while (index > 0 && items[index] > items[Parent(index)])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }

        }

        private void BubbleDown()
        {
            var index = 0;
            while (index <= size && !IsValidParent(index))
            {
                var largerChildIndex = LargerChildIndex(index);
                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private int LargerChildIndex(int index) =>
            (LeftChild(index) > RightChild(index)) ? LeftChildIndex(index) : RightChildIndex(index);
        private bool IsValidParent(int index) => items[index] >= LeftChild(index) && items[index] >= RightChild(index);
        //private bool HasLeftChild
        private int LeftChild(int index) => items[LeftChildIndex(index)];
        private int RightChild(int index) => items[RightChildIndex(index)];
        private int LeftChildIndex(int parent) => parent * 2 + 1;
        private int RightChildIndex(int parent) => parent * 2 + 2;
        private int Parent(int index) => (index - 1) / 2;
        private void Swap(int first, int second) => (items[first], items[second]) = (items[second], items[first]);

        private bool IsFull => size == items.Length;
        private bool IsEmpty => size == 0;
    }
}
