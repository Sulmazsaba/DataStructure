namespace DataStructure.GraphsSolutions.Weighted
{
    public partial class WeightedGraph
    {
        private class NodeEntry
        {
            internal Node node;
            internal int priority;

            public NodeEntry(Node node, int priority)
            {
                this.node = node;
                this.priority = priority;
            }
        }
    }
}
