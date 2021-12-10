using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TriesSolution
{
    public class Trie
    {
        private readonly Node _root = new Node((char)0);
        public void Insert(string word)
        {
            var current = _root;
            foreach (var ch in word.ToCharArray())
            {
                if(!current.HasChild(ch)) 
                  current.AddChild(ch);

                current = current.GetChild(ch);

            }

            current.IsEndOfWord = true;
        }

        public bool Contains(string word)
        {
            var current = _root;
            foreach (var ch in word.ToCharArray())
            {
                if (!current.HasChild(ch))
                    return false;

                
                current =current.GetChild(ch);
            }

            return current.IsEndOfWord;
        }

     
        private class Node
        {
            private readonly char _value;
            private readonly Dictionary<char,Node> _children;
            public bool IsEndOfWord { get; set; }

            public Node(char value)
            {
                this._value = value;
                _children = new Dictionary<char, Node>();
            }

            public override string ToString()
            {
                return $"value = {_value}";
            }

            public bool HasChild(char ch) => _children.ContainsKey(ch);
            public void AddChild(char ch) => _children.Add(ch, new Node(ch));
            public Node GetChild(char ch) => _children[ch];
            //public void EndWord() => IsEndOfWord = true;

        }
    }
}
