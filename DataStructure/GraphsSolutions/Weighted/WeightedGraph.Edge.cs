namespace DataStructure.GraphsSolutions.Weighted
{
    public partial class WeightedGraph
    {
        private class Edge
        {
            internal int weight;
            internal Node from;
            internal Node to;

            public Edge(int weight, Node from, Node to)
            {
                this.weight = weight;
                this.from = from;
                this.to = to;
            }

            public override string ToString()
            {
                return @$"{from.label} to {to.label} ";
            }
        }
    }
}
