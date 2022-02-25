using System.Collections.Generic;

namespace DataStructure.GraphsSolutions.Weighted
{
    public partial class WeightedGraph
    {
        private class Node
        {

            public string label;
            private List<Edge> _edges = new List<Edge>();
            public Node(string label)
            {
                this.label = label;
            }

            public void AddEdge(Node to, int weight)
            {
                _edges.Add(new Edge(weight, this, to));
            }


            public List<Edge> GetEdges()
            {
                return _edges;
            }
        }
    }
}
