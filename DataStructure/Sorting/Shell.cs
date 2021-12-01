using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public static class Shell
    {
        public static void Sort(int[] arr, int n)
        {
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    var gValue = arr[i];
                    var j = i - gap;

                    while (j >= 0 && arr[j] > gValue)
                    {
                        arr[j + gap] = arr[j];
                        j = j - gap;
                    }

                    arr[j + gap] = gValue;
                }

            }

        }
    }
}
