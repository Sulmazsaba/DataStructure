using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TreeSolutions
{
    public class Tree
    {
        private Node Root { get; set; }

        public void Insert(int value)
        {
            var newNode = new Node(value, null, null);
            if (IsEmpty())
            {
                Root = newNode;
                return;

            }
            var current = Root;

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = newNode;
                        break;
                    }
                    current = current.LeftChild;

                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = newNode;
                        break;
                    }

                    current = current.RightChild;

                }
            }
        }

        public bool Find(int value)
        {
            var current = Root;

            while (current != null)
            {
                if (current.Value > value)
                    current = current.LeftChild;
                else if (current.Value < value)
                    current = current.RightChild;
                else return true;
            }

            return false;
        }

        private class Node
        {
            public int Value;
            public Node LeftChild;
            public Node RightChild;

            public Node(int value, Node leftChild, Node rightChild)
            {
                Value = value;
                LeftChild = leftChild;
                RightChild = rightChild;
            }
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.Value);
            TraversePreOrder(root.LeftChild);
            TraversePreOrder(root.RightChild);

        }
        private int Height(Node root)
        {
            if (root == null)
                return -1;
            if (root.LeftChild == null && root.RightChild == null)
                return 0;
            return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
        }
        private int MinValue(Node root)
        {
            if (IsLeaf(root))
                return root.Value;

            var leftMin = MinValue(root.LeftChild);
            var rightMin = MinValue(root.RightChild);
            return Math.Min(root.Value, Math.Min(leftMin, rightMin));
        }
        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null)
                return true;

            if (first != null && second != null)
                return first.Value == second.Value && Equals(first.LeftChild, second.LeftChild) && Equals(first.RightChild, second.RightChild);

            return false;

        }
        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
                return true;


            if (root.Value < min || root.Value > max)
                return false;

            return IsBinarySearchTree(root.LeftChild, min, root.Value - 1) && IsBinarySearchTree(root.RightChild, root.Value + 1, max);
        }

        private int GetNodeAtDistance(int k, Node root)
        {
            if (root == null)
                return -1;

            if (k == 0)
            {
                Console.Write(root.Value + ",");
                return -1;
            }

            GetNodeAtDistance(k - 1, root.LeftChild);
            GetNodeAtDistance(k - 1, root.RightChild);
            return -1;
        }

        public void LevelOrderTraversal()
        {
            for (int i = 0; i < Height(Root); i++)
                GetNodeAtDistance(i);

        }

        public int GetNodeAtDistance(int k) => GetNodeAtDistance(k, Root);
        public bool IsBinarySearchTree() => IsBinarySearchTree(Root, int.MinValue, int.MaxValue);

        public void TraversePreOrder() => TraversePreOrder(Root);
        public int MinValue() => MinValue(Root);
        public int Height() => Height(Root);

        private bool IsEmpty() => Root == null;
        private bool IsLeaf(Node root) => root.LeftChild == null && root.RightChild == null;
        public bool Equals(Tree tree) => Equals(Root, tree.Root);
    }
}
