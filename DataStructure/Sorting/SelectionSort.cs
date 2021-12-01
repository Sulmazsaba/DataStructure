using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
  public static  class SelectionSort
    {

        public static void Sort(int[] a, int n)
        {
            for (var i = 0; i < n - 1; i++)
            {
                var position = i;
                for (var j = i + 1; j < n; j++)
                {
                    if (a[position] > a[j])
                    {
                        position = j;

                    }
                }

                (a[i], a[position]) = (a[position], a[i]);
            }

        }

    }
}
