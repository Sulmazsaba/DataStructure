using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TriesSolution
{
    public partial class Trie
    {
        private readonly Node _root = new Node((char)0);
        public void Insert(string word)
        {
            var current = _root;
            foreach (var ch in word.ToCharArray())
            {
                if (!current.HasChild(ch))
                    current.AddChild(ch);

                current = current.GetChild(ch);

            }

            current.IsEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (word == null)
                return false;
            var current = _root;
            foreach (var ch in word.ToCharArray())
            {
                if (!current.HasChild(ch))
                    return false;
                current = current.GetChild(ch);
            }

            return current.IsEndOfWord;
        }

        public void Traverse() => Traverse(_root);

        private void Traverse(Node root)
        {
            Console.WriteLine($"{root.Value} , isEnded =  {root.IsEndOfWord}");
            foreach (var child in root.GetChildren())
            {
                Traverse(child);
            }
        }

        public void Remove(string word)
        {
            if (word == null)
                return;

            Remove(_root, word, 0);
        }

        private void Remove(Node root, string word, int index)
        {
            if (index == word.Length)
            {
                root.IsEndOfWord = false;
                return;
            }

            var ch = word.ToCharArray()[index];
            var child = root.GetChild(ch);

            if (child == null)
                return;

            Remove(child, word, index + 1);

            if (!child.HasChildren() && !child.IsEndOfWord)
                root.RemoveChild(ch);
        }

        public ArrayList FindWords(string prefix)
        {

            var words = new ArrayList();
            var lastNode = FindLastNodeOf(prefix);
            FindWords(lastNode, prefix, words);
            return words;

        }

        private void FindWords(Node root, string prefix, ArrayList words)
        {
            if (root.IsEndOfWord)
                words.Add(prefix);

            foreach (var child in root.GetChildren())
            {
                FindWords(child, prefix + child.Value, words);
            }
        }

        private Node FindLastNodeOf(string prefix)
        {
            var current = _root;
            foreach (var ch in prefix.ToCharArray())
            {
                var child = current.GetChild(ch);
                if (child == null)
                    return null;
                current = child;

            }

            return current;
        }
    }
}
