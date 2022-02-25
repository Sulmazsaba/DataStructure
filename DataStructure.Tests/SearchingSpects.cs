using DataStructure.Searching;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.Tests
{
    public class SearchingSpects
    {
        [Fact]
        public void Binary_search_should_work_correct()
        {
            //int[] arr = new[] { 1, 5, 3, 9, 33, 8 };

            int[] sortedArr = new[] { 1, 2, 4, 6, 10, 313, 413, 490, 501, 506, 543, 566 };

            var res = BinarySearch.Search(sortedArr, 7, 10);
            res.Should().Be(4);

            res = BinarySearch.Search(sortedArr, 7, 9);
            res.Should().Be(-1);

            res = BinarySearch.RecSearch(sortedArr, 0, sortedArr.Length, 10);
            res.Should().Be(4);

            res = BinarySearch.RecSearch(sortedArr, 0, sortedArr.Length, 9);
            res.Should().Be(-1);


            //var index = JumpSearch.Search(sortedArr, 413);
            //var index = ExponentialSearch.Search(sortedArr, 543);

        }

        [Fact]
        public void Linear_search_should_work_correctly()
        {
            int[] sortedArr = new[] { 1, 2, 4, 6, 10, 313, 413, 490, 501, 506, 543, 566 };
            LinearSearch search = new LinearSearch();
            var res = BinarySearch.Search(sortedArr, 7, 10);
            res.Should().Be(4);

            res = search.Search(sortedArr, 7, 9);
            res.Should().Be(-1);
        }

        [Fact]
        public void Ternary_search_should_work_fine()
        {

            int[] sortedArr = new[] { 1, 2, 4, 6, 10, 313, 413, 490, 501, 506, 543, 566 };
            var index = TernarySearch.Search(sortedArr, 0, sortedArr.Length - 1, 506);
            index.Should().Be(9);
        }
    }
}
