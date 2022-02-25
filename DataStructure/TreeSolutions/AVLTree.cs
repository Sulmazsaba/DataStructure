using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TreeSolutions
{
    public partial class AVLTree
    {
        private AVLNode root;

        private AVLNode Insert(int value, AVLNode root)
        {
            if (root == null)
                return new AVLNode(value);

            if (value < root.Value)
            {
                root.leftChild = Insert(value, root.leftChild);
            }
            else
            {
                root.rightChild = Insert(value, root.rightChild);
            }

            root.height = Math.Max(Height(root.leftChild), Height(root.rightChild)) + 1;

            Balance(root);
            return root;

        }

        private AVLNode RotateLeft(AVLNode root)
        {
            var newRoot = root.rightChild;

            root.rightChild = newRoot.leftChild;
            newRoot.leftChild = root;

            root.height = Math.Max(Height(root.leftChild), Height(root.rightChild)) + 1;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private AVLNode RotateRight(AVLNode root)
        {
            var newRoot = root.leftChild;

            root.leftChild = newRoot.rightChild;
            newRoot.rightChild = root;

            root.height = Math.Max(Height(root.leftChild), Height(root.rightChild)) + 1;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private void Balance(AVLNode root)
        {
            if (IsRightHeavy(root))
            {
                if (BalanceFactor(root.rightChild) > 0)
                    RotateRight(root.rightChild);
                RotateLeft(root);

            }

            if (IsLeftHeavy(root))
            {
                if (BalanceFactor(root.leftChild) < 0)
                    RotateLeft(root.leftChild);
                RotateRight(root);
            }
            
        }
        private void SetHeight(AVLNode node) => node.height = Math.Max(Height(node.leftChild), Height(node.rightChild)) + 1;
        private int Height(AVLNode node) => node?.height ?? -1;
        private bool IsEmpty() => root == null;
        private bool IsLeftHeavy(AVLNode node) => BalanceFactor(node) > 1;
        private bool IsRightHeavy(AVLNode node) => BalanceFactor(node) < -1;
        private int BalanceFactor(AVLNode node) => (node == null) ? 0 : Height(node.leftChild) - Height(node.rightChild);
        public void Insert(int value) => root = Insert(value, root);
    }
}
