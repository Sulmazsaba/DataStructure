using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Searching
{
    public static class JumpSearch
    {
        public static int Search(int[] array, int target)
        {
            var blockSize = (int)Math.Sqrt(array.Length);
            var start = 0;
            var next = blockSize;

            while (start <= array.Length && array[next - 1] < target)
            {
                start = next;
                
                next += blockSize;
                if (next > array.Length)
                    next = array.Length;
            }

            for (int i = start; i < next; i++)
            {
                if (array[i] == target)
                    return i;
            }

            return -1;

        }
    }
}
