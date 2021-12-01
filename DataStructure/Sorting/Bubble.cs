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

    }
}
