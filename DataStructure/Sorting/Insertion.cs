using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public static class Insertion
    {
        public static void Sort(int[] a, int n)
        {
            for (int i = 1; i < n; i++)
            {
                var cValue = a[i];
                var position = i;
                while (position >0 && a[position - 1] > cValue)
                {
                    a[position] = a[position - 1];
                    position--;
                }

                a[position] = cValue;
            }
        }
    }
}
