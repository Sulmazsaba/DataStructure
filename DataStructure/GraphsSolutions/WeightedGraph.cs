using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.GraphsSolutions
{
   public class WeightedGraph
    {

        private readonly Dictionary<string, Node> _nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Edge>> _adjList = new Dictionary<Node, List<Edge>>();

        public void AddNode(string label)
        {
            var newNode = new Node(label);
            if (!_nodes.ContainsKey(label))
                _nodes.Add(label, newNode);

            _adjList.Add(newNode, new List<Edge>());
        }

        public void AddEdge(string from, string to,int weight)
        {
            var fromNode = _nodes[from];
            if (fromNode == null)
                throw new InvalidOperationException();

            var toNode = _nodes[to];
            if (toNode == null)
                throw new InvalidOperationException();

            _adjList[fromNode].Add(new Edge(weight,fromNode,toNode));
            _adjList[toNode].Add(new Edge(weight,toNode,fromNode));
        }
        public void Print()
        {
            foreach (var source in _adjList.Keys)
            {
                var target = _adjList[source];
                if (target != null)
                {
                    foreach (var node in target)
                    {
                        Console.WriteLine($" {node.ToString()}");
                    }
                }
            }
        }

        private class Node
        {

            public string label;
            public Node(string label)
            {
                this.label = label;
            }

        }

        private class Edge
        {
            private int weight;
            private Node from;
            private Node to;

            public Edge(int weight, Node @from, Node to)
            {
                this.weight = weight;
                this.@from = @from;
                this.to = to;
            }

            public override string ToString()
            {
                return @$"{from.label} to {to.label} ";
            }
        }
    }
}
