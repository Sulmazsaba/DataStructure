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
                var current = a[i];
                var position = i;
                while (position >0 && a[position - 1] > current)
                {
                    a[position] = a[position - 1];
                    position--;
                }

                a[position] = current;
            }
        }
        
    }
}
