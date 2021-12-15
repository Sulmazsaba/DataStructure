using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Searching
{
    public static class ExponentialSearch
    {
        public static int Search(int[] array, int target)
        {
            int bound = 1;
            while (bound < array.Length && array[bound] < target)
                bound *= 2;

            return BinarySearch.RecSearch(array, bound / 2, Math.Min(bound, array.Length - 1), target);
        }
    }
}
