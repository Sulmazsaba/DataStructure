using DataStructure.Sorting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.Tests
{
    public class SortingSpecs
    {
        [Fact]
        public void Bubble_sorting_should_be_sorted_correcly()
        {
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 11, 10, 10, 10 };
            Bubble.Sort(arr);

            int[] expectedRes = { 1, 2, 4, 5, 8, 10, 10, 10, 10, 11, 12 };
            arr.Should().BeEquivalentTo(expectedRes);

            
            //Shell.Sort(arr, arr.Length);
            //Counting.Sort(arr, 19);
            //BucketSort.Sort(arr, 4);
        }

        [Fact]
        public void Selecting_sorting_should_be_sorted_correcly()
        {
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 11, 10, 10, 10 };
            SelectionSort.Sort(arr, arr.Length);

            int[] expectedRes = { 1, 2, 4, 5, 8, 10, 10, 10, 10, 11, 12 };
            arr.Should().BeEquivalentTo(expectedRes);
        }

        [Fact]
        public void Insertion_sorting_should_be_sorted_correcly()
        {
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 11, 10, 10, 10 };

            Insertion.Sort(arr, arr.Length);

            int[] expectedRes = { 1, 2, 4, 5, 8, 10, 10, 10, 10, 11, 12 };
            arr.Should().BeEquivalentTo(expectedRes);
        }

        [Fact]
        public void Merge_sorting_should_be_sorted_correcly()
        {
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 11, 10, 10, 10 };
            var arr3 = MergeSort.Sort(arr.ToList());

            int[] expectedRes = { 1, 2, 4, 5, 8, 10, 10, 10, 10, 11, 12 };
            arr3.Should().BeEquivalentTo(expectedRes);
        }

        [Fact]
        public void Quick_sorting_should_be_sorted_correcly()
        {
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 11, 10, 10, 10 };

            QuickSort.Sort(arr, 0, arr.Length - 1);

            int[] expectedRes = { 1, 2, 4, 5, 8, 10, 10, 10, 10, 11, 12 };
            arr.Should().BeEquivalentTo(expectedRes);
        }
    }
}
