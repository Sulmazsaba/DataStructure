using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Searching
{
    public class BinarySearch
    {
        public int Search(int[] arr, int n, int key)
        {
            var l = 0;
            var r = n - 1;
            while (l <= r)
            {
                var m = (l + r) / 2;
                if (arr[m] == key)
                    return l;
                else if (key < arr[m])
                    r = m - 1;
                else if (key > arr[m])
                    l = m + 1;
              
            }

            return -1;
        }

        public int RecSearch(int[] arr,int left, int right, int key)
        {
            if (left < right)
            {
                var m = (left + right) / 2;
                if (arr[m] == key)
                    return m;
                else if(key<arr[m])
                {
                    return RecSearch(arr, left, m - 1, key);
                }
                else if(key>arr[m])
                {
                    return RecSearch(arr, m + 1, right, key);
                }

            }

            return -1;
        }
    }
}
