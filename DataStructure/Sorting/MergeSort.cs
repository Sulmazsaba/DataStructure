using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public static class MergeSort
    {

        public static List<int> Sort(List<int> numbers)
        {
            if (numbers.Count <= 1)
                return numbers;

            //Divide this array into half
            var m = numbers.Count / 2;


            //Sort each half
            var leftArray = new List<int>();
            for (var i = 0; i < m; i++)
                leftArray.Add(numbers[i]);


            var rightArray = new List<int>();
            for (var i = m; i < numbers.Count; i++)
                rightArray.Add(numbers[i]);

            leftArray = Sort(leftArray);
            rightArray = Sort(rightArray);
            //Merge the result
            return Merge(leftArray, rightArray);
        }


        private static List<int> Merge(List<int> left, List<int> right)
        {
            //var resultLength = left.Count + right.Length;
            var result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.RemoveAt(0);

                }
            }

            return result;

        }
    }
}
