using System.Collections.Generic;

namespace DataStructure.GraphsSolutions.Weighted
{
    public partial class WeightedGraph
    {
        private class EdgeComparer : IComparer<Edge>
        {
            public int Compare(Edge x, Edge y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.weight.CompareTo(y.weight);
            }
        }
    }
}
