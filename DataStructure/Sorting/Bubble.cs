using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public static class Bubble
    {
        public static void Sort(int[] a, int n)
        {
            for (int pass = n - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (a[i] > a[i + 1])
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                }
            }
        }

        public static void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }

                }
            }

        }


    }
}
