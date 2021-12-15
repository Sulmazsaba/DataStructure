using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public static class Counting
    {
        public static void Sort(int[] array,int max)
        {
            //filling counting array
            var counts = new int[max + 1];
            foreach (var item in array)
                counts[item]++;

            var k = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[k++] = i;
                }
            }

        }
    }
}
