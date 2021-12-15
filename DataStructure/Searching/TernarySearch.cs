using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Searching
{
    public static class TernarySearch
    {
        public static int Search(int[] array, int left, int right, int number)
        {
            if (left > right)
                return -1;

            var partitionSize = (right - left) / 2;
            var mid1 = left + partitionSize;
            var mid2 = right - partitionSize;

            if (array[mid1] == number)
                return mid1;
            if (number == array[mid2])
                return mid2;
            if (number < array[mid1])
                return Search(array, left, mid1 - 1, number);

            if (number > array[mid1] && number < array[mid2])
                return Search(array, mid1 + 1, mid2 - 1, number);

            if (number > array[mid2])
                return Search(array, mid2 + 1, right, number);
            return -1;

        }
    }
}
