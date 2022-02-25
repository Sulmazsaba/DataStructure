using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Common.Utilities;

namespace DataStructure.GraphsSolutions.Weighted
{
    public partial class WeightedGraph
    {

        private readonly Dictionary<string, Node> _nodes = new Dictionary<string, Node>();

        public void AddNode(string label)
        {
            var newNode = new Node(label);
            if (!_nodes.ContainsKey(label))
                _nodes.Add(label, newNode);

        }

        public void AddEdge(string from, string to, int weight)
        {
            var fromNode = _nodes[from];
            if (fromNode == null)
                throw new InvalidOperationException();

            var toNode = _nodes[to];
            if (toNode == null)
                throw new InvalidOperationException();

            fromNode.AddEdge(toNode, weight);
            toNode.AddEdge(toNode, weight);
        }

        public void Print()
        {
            foreach (var node in _nodes.Values)
            {
                var edges = node.GetEdges();
                if (edges.Count != 0)
                {
                    foreach (var edge in edges)
                    {
                        Console.WriteLine($" {node.ToString()}");
                    }
                }
            }
        }


        public bool HasCycle()
        {
            HashSet<Node> visited = new HashSet<Node>();
            foreach (var node in _nodes.Values)
            {
                if (!visited.Contains(node) && HasCycle(node, null, visited))
                {
                    return true;
                }

            }

            return false;
        }

        private bool HasCycle(Node node, Node parent, HashSet<Node> visited)
        {
            visited.Add(node);
            foreach (var edge in node.GetEdges())
            {
                if (edge.to == parent)
                    continue;

                if (visited.Contains(edge.to) || HasCycle(edge.to, node, visited))
                    return true;
            }

            return false;
        }

        public WeightedGraph GetMinSpanningTree()
        {
            var tree = new WeightedGraph();
            PriorityQueue<Edge> edges = new PriorityQueue<Edge>(new EdgeComparer());

            var first = _nodes.Values.FirstOrDefault();
            foreach (var edge in first.GetEdges()) edges.Enqueue(edge);

            tree.AddNode(first.label);

            while (tree._nodes.Count < _nodes.Count)
            {
                var minEdge = edges.Dequeue();
                var nextNode = minEdge.to;
                if (tree.ContainsNode(nextNode.label))
                    continue;
                tree.AddNode(nextNode.label);
                tree.AddEdge(minEdge.from.label, minEdge.to.label, minEdge.weight);
                foreach (var edge in nextNode.GetEdges())
                {
                    if (!tree.ContainsNode(edge.to.label))
                        edges.Enqueue(edge);
                }
            }

            return tree;
        }
        public int GetShortestDistance(string from, string to)
        {
            Dictionary<Node, int> distances = new Dictionary<Node, int>();
            foreach (var node in _nodes.Values)
            {
                distances.Add(node, int.MaxValue);
            }

            var fromNode = _nodes[from];
            distances[fromNode] = 0;

            HashSet<Node> visited = new HashSet<Node>();
            PriorityQueue<NodeEntry> queue = new PriorityQueue<NodeEntry>(new NodeComparer());
            queue.Enqueue(new NodeEntry(fromNode, 0));

            while (queue.Count != 0)
            {
                var current = queue.Dequeue().node;
                visited.Add(current);

                foreach (var edge in current.GetEdges())
                {
                    if (visited.Contains(edge.to))
                        continue;

                    var newDistance = distances[current] + edge.weight;
                    if (newDistance < distances[edge.to])
                        distances[edge.to] = newDistance;
                    queue.Enqueue(new NodeEntry(edge.to, newDistance));
                }
            }
            return distances[_nodes[to]];
        }

        public bool ContainsNode(string label) => _nodes.ContainsKey(label);
    }
}
