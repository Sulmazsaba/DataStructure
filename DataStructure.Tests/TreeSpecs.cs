using DataStructure.HeapSolutions;
using DataStructure.TreeSolutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;


namespace DataStructure.Tests
{
    public class TreeSpecs
    {
        [Fact]
        public void Tree_should_work_fine()
        {

            Tree tree = new Tree();
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(2);
            tree.Insert(15);


            Tree tree2 = new Tree();
            tree2.Insert(4);
            tree2.Insert(10);
            tree2.Insert(2);
            tree2.Insert(15);

            var isEqual = tree.Equals(tree2);
            isEqual.Should().Be(true);

            tree.Insert(6);
            tree.Insert(1);
            tree.Insert(3);

            var result = tree.Find(10);
            result.Should().Be(true);

            result = tree.Find(5);
            result.Should().Be(false);

            var height = tree.Height();
            height.Should().Be(2);

            var isBinaryTree = tree.IsBinarySearchTree();
            isBinaryTree.Should().BeTrue();

            var minValue = tree.MinValue();
            minValue.Should().Be(1);

            var node = tree.GetNodeAtDistance(1);


            isEqual = tree.Equals(tree2);
            isEqual.Should().Be(false);

        }

        [TestMethod]
        [Fact]
        public void Traverse_pre_order_should_work_correct()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Tree tree = new Tree();
                tree.Insert(4);
                tree.Insert(10);
                tree.Insert(2);
                tree.Insert(15);
                tree.Insert(6);
                tree.Insert(1);


                tree.TraversePreOrder();

                var expected = string.Format("4{0}", Environment.NewLine)
                    + string.Format("2{0}", Environment.NewLine)
                    + string.Format("1{0}", Environment.NewLine)
                    + string.Format("6{0}", Environment.NewLine)
                    + string.Format("10{0}", Environment.NewLine)
                    + string.Format("15");

                //sw..Should().Be("4261015");
            }
        }

        [Fact]
        public void Traverse_level_order_should_work_fine()
        {

        }

        [Fact]
        public void AVL_tree_should_work_fine()
        {
            AVLTree avlTree = new AVLTree();
            avlTree.Insert(1);
            avlTree.Insert(2);
            avlTree.Insert(3);
        }

        [Fact]
        public void Heap_should_work_correct()
        {
            var heap = new Heap();
            heap.Insert(10);
            heap.Insert(2);
            heap.Insert(11);
            heap.Insert(4);
            heap.Insert(22);
            var removedItem = heap.Remove();
            removedItem.Should().Be(22);
        }

        [Fact]
        public void Heap_sort_should_work_correct()
        {
            var heap = new Heap();
            int[] numbers = { 1, 10, 32, 5, 4, 9 };
            foreach (var number in numbers)
            {
                heap.Insert(number);
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = heap.Remove();
            }

            var result = string.Join(",", numbers);
            result.Should().Be("1,4,5,9,10,32");

        }

        [Fact]
        public void Heapify_max_heap_should_work_fine()
        {
            int[] numbers = { 4, 2, 6, 22, 3, 99 };

            MaxHeap.Heapify(numbers);
            var res = String.Join(",", numbers);

            res.Should().Be("99,22,6,4,3,2");
        }

        [Fact]
        public void Find_kth_largest_in_max_heap()
        {
            int[] numbers = { 4, 2, 6, 22, 3, 99 };

            var res = MaxHeap.GetKthLargest(numbers, 2);
            res.Should().Be(22);
        }
    }
}
