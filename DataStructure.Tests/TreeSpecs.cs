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
    }
}
