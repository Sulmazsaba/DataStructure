namespace DataStructure.TreeSolutions
{
    public partial class AVLTree
    {
        private class AVLNode
        {
            public int Value;
            public AVLNode leftChild;
            public AVLNode rightChild;
            public int height;

            public AVLNode(int value, AVLNode leftChild = null, AVLNode rightChild = null)
            {
                Value = value;
                leftChild = leftChild;
                rightChild = rightChild;
            }

            public override string ToString()
            {
                return $"Value = {this.Value}";
            }
        }
    }
}
