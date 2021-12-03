using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Searching
{
  public class LinearSearch
    {
        public int Search(int[] arr,int n,int key)
        {
            int index = 0;
            while (index<n)
            {
                if (arr[index] == key)
                    return index;

                index++;
            }

            return -1;
        }
    }
}
