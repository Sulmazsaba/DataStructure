using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
   public static class QuickSort
    {
        /// <summary>
        /// using start and end parameter in method to reduce space complexity
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void Sort(int[] array,int start, int end)
        {
            if(start>=end)
                return;

            //Partition
            var boundary = Partition(array,start,end);

            //sort left array
            Sort(array,start,boundary-1);

            //sort right array

            Sort(array,boundary+1,end);
        }

        /// <summary>
        /// return index of pivot after placing in right place
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int Partition(int[] array,int start,int end)
        {
            var pivot = array[end];
            var boundary = start-1;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= pivot)
                {
                    boundary++;
                    (array[i], array[boundary]) = (array[boundary], array[i]);
                }
            }

            return boundary;

        }
    }
}
