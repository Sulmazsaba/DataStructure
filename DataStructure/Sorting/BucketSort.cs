using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public static class BucketSort
    {

        public static void Sort(int[] array, int numberOfBucket)
        {
            var k = 0;
            foreach (var bucket in CreateBucket(array, numberOfBucket))
            {
                bucket.Sort();
                foreach (var item in bucket)
                {
                    array[k++] = item;
                }
            }

        }

        private static List<List<int>> CreateBucket(int[] array, int numberOfBucket)
        {
            var buckets = new List<List<int>>();
            for (int i = 0; i < numberOfBucket; i++)
                buckets.Add(new List<int>());

            //adding items from array to bucket
            foreach (var item in array)
            {
                buckets[item / numberOfBucket].Add(item);
            }

            return buckets;
        }

    }
}
