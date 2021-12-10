using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.GraphsSolutions
{
    public class Graph
    {

        private readonly Dictionary<string, Node> _nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Node>> _adjList = new Dictionary<Node, List<Node>>();
        public void AddNode(string label)
        {
            var newNode = new Node(label);
            if (!_nodes.ContainsKey(label))
                _nodes.Add(label, newNode);

            _adjList.Add(newNode, new List<Node>());

        }

        public void RemoveNode(string label)
        {
            if (!_nodes.ContainsKey(label))
                return;
            var node = _nodes[label];


            foreach (var source in _adjList.Keys)
            {
                _adjList[source].Remove(node);
            }

            _adjList.Remove(node);
            _nodes.Remove(node.label);
        }

        public void AddEdge(string from, string to)
        {
            var fromNode = _nodes[from];
            if (fromNode == null)
                throw new InvalidOperationException();

            var toNode = _nodes[to];
            if (toNode == null)
                throw new InvalidOperationException();

            _adjList[fromNode].Add(toNode);
        }

        public void RemoveEdge(string from, string to)
        {
            var toNode = _nodes[to];
            var fromNode = _nodes[from];

            if (fromNode == null || toNode == null)
                return;

            _adjList[fromNode].Remove(toNode);

        }

        public void TraverseDepthFirst(string root)
        {
            var visited = new HashSet<Node>();
            var node = _nodes[root];
            TraverseDepthFirst(node, visited);
        }

        private void TraverseDepthFirst(Node root, HashSet<Node> visited)
        {
            Console.WriteLine(root.label);
            visited.Add(root);
            foreach (var node in _adjList[root])
            {
                if (!visited.Contains(node))
                    TraverseDepthFirst(node, visited);
            }
        }

        public void TraverseBreadthFirst(string root)
        {
            var visited = new HashSet<Node>();
            Queue<Node> queue = new Queue<Node>();

            var node = _nodes[root];
            if (node == null)
                return;

            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (visited.Contains(current))
                    continue;

                Console.WriteLine(current.label);
                visited.Add(current);

                foreach (var neighbour in _adjList[current])
                {
                    if (!visited.Contains(neighbour))
                        queue.Enqueue(neighbour);
                }
            }


        }

        public void TopologicalSort()
        {
            Stack<Node> stack = new Stack<Node>();
            var visited = new HashSet<Node>();

            foreach (var node in _nodes.Values)
                TopologicalSort(node, visited, stack);


            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop().label);
            }
        }

        private void TopologicalSort(Node root, HashSet<Node> visited, Stack<Node> stack)
        {
            if (visited.Contains(root))
                return;

            visited.Add(root);

            foreach (var node in _adjList[root])
                TopologicalSort(node, visited, stack);

            stack.Push(root);
        }

        public bool HasCycle()
        {
            HashSet<Node> all = new HashSet<Node>();
            foreach (var nodesValue in _nodes.Values) all.Add(nodesValue);

            HashSet<Node> visiting = new HashSet<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            while (all.Any())
            {
                var current = all.ToArray()[0];
                if (HasCycle(current, all, visiting, visited))
                    return true;
            }

            return false;

        }

        private bool HasCycle(Node node, HashSet<Node> all, HashSet<Node> visiting, HashSet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);

            foreach (var neighbour in _adjList[node])
            {
                if (visited.Contains(neighbour))
                    continue;

                if (visiting.Contains(node))
                    return true;
                if (HasCycle(neighbour, all, visiting, visited)) return true;
            }

            visited.Add(node);
            visiting.Remove(node);
            return false;
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
                        Console.WriteLine($"relations from {source.label} to {node.label}");
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
    }
}
