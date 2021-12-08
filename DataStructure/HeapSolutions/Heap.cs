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

        public int Remove()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            var root = items[0];
            items[0] = items[--size];

            BubbleDown();

            return root;
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

     

        private int LargerChildIndex(int index)
        {
            if (!HasLeftChild(index))
                return index;
            if (!HasRightChild(index))
                return LeftChildIndex(index);

            return (LeftChild(index) > RightChild(index)) ? LeftChildIndex(index) : RightChildIndex(index);
        }
        private bool IsValidParent(int index)
        {
            if (!HasLeftChild(index))
                return true;

            var isValid = items[index] >= LeftChild(index);
            if (HasRightChild(index))
                return isValid &items[index] >= RightChild(index);

            return isValid;
        } 
        private bool HasLeftChild(int index) => LeftChildIndex(index) <= size;
        private bool HasRightChild(int index) => RightChildIndex(index) <= size;
        private int LeftChild(int index) => items[LeftChildIndex(index)];
        private int RightChild(int index) => items[RightChildIndex(index)];
        private int LeftChildIndex(int parent) => parent * 2 + 1;
        private int RightChildIndex(int parent) => parent * 2 + 2;
        private int Parent(int index) => (index - 1) / 2;
        private void Swap(int first, int second) => (items[first], items[second]) = (items[second], items[first]);

        private bool IsFull => size == items.Length;
        public bool IsEmpty => size == 0;
    }
}
