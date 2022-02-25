using System.Collections.Generic;

namespace DataStructure.GraphsSolutions.Weighted
{
    public partial class WeightedGraph
    {
        private class NodeComparer : IComparer<NodeEntry>
        {
            public int Compare(NodeEntry x, NodeEntry y) => y.priority - x.priority;
        }
    }
}
