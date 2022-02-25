using System.Collections.Generic;
using System.Linq;

namespace DataStructure.TriesSolution
{
    public partial class Trie
    {
        private class Node
        {
            public readonly char Value;
            private readonly Dictionary<char, Node> _children;
            public bool IsEndOfWord { get; set; }


            public Node(char value)
            {
                this.Value = value;
                _children = new Dictionary<char, Node>();
            }

            public override string ToString()
            {
                return $"value = {Value} , IsEnded ={IsEndOfWord}";
            }

            public bool HasChild(char ch) => _children.ContainsKey(ch);
            public void AddChild(char ch) => _children.Add(ch, new Node(ch));
            public Node GetChild(char ch) => _children[ch];
            public Node[] GetChildren() => _children.Values.ToArray();
            public bool HasChildren() => _children.Any();

            public void RemoveChild(char ch) => _children.Remove(ch);

        }
    }
}
