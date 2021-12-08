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

            while (current!=null)
            {
                if (current.Value > value)
                    current = current.LeftChild;
                else if (current.Value < value)
                    current = current.RightChild;
                else return true;
            }

            return false;
        }

        private bool IsEmpty() => Root == null;

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

        public void TraversePreOrder()
        {
            TraversePreOrder(Root);
        }
        private void TraversePreOrder(Node root)
        {
            if(root==null)
                return;
            
            Console.WriteLine(root.Value);
            TraversePreOrder(root.LeftChild);
            TraversePreOrder(root.RightChild);

        }
    }
}
