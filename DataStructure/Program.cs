using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.GraphsSolutions;
using DataStructure.HashTableSolutions;
using DataStructure.HeapSolutions;
using DataStructure.LinkedList;
using DataStructure.LinkedList.CircularLinkedList;
using DataStructure.LinkedList.DoublyLinkedList;
using DataStructure.Queues;
using DataStructure.Searching;
using DataStructure.Sorting;
using DataStructure.Stack;
using DataStructure.StringManipulation;
using DataStructure.TreeSolutions;
using DataStructure.TriesSolution;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCircularLinkedList();
            //TestDoublyLinkedList();
            //Recursion recursion = new Recursion();
            //Console.WriteLine(recursion.Factorial(0));

            //TestHeap();
            //HeapSort();
            //TestHeapify();
            //TestTrie();
            //TestDirectedGraph();
            StringManipulation();

        }

        private static void StringManipulation()
        {
            string word = "this is my world";
            //Console.WriteLine(StringUtils.CountVowels(word));
            //Console.WriteLine(StringUtils.Reverse("hello"));
            //Console.WriteLine(StringUtils.ReverseWords(word));
            //Console.WriteLine(StringUtils.IsRotated("ABCD","BCDD"));
            //StringUtils.RemoveDuplicateChar(ref word);
            //Console.WriteLine(StringUtils.GetMostRepeatedChar("thisismemyfriends"));
            //Console.WriteLine(StringUtils.Capitalize(word));
            //Console.WriteLine(StringUtils.AreAnagrams("SABa","BASA"));
            Console.WriteLine(StringUtils.ArePalindrome("ABBAS"));
        }
        private static void TestDirectedGraph()
        {
            WeightedGraph graph = new WeightedGraph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddEdge("A", "B", 2);
            graph.AddEdge("B", "C", 3);
            graph.AddEdge("C", "A", 10);
            Console.WriteLine(graph.GetShortestDistance("A", "C"));
            Console.WriteLine(graph.HasCycle());
            graph.Print();
        }

        private static void TestTrie()
        {
            Trie trie = new Trie();
            trie.Insert("canada");
            trie.Insert("can");
            trie.Insert("car");
            trie.Insert("cancer");
            //trie.Insert("cardinal");
            //trie.Insert("care");
            //trie.Insert("car");
            //Console.WriteLine(trie.Contains("can"));
            //trie.Traverse();
            //trie.Remove("canada");
            //trie.Traverse();


            var list = trie.FindWords("can");
            Console.WriteLine(list.Count);
        }
        private static void TestAVLTree()
        {
            AVLTree avlTree = new AVLTree();
            avlTree.Insert(1);
            avlTree.Insert(2);
            avlTree.Insert(3);
            Console.WriteLine();
        }

        private static void TestHeapify()
        {

            int[] numbers = { 4, 2, 6, 22, 3, 99, 100, 1, 55, 23 };
            Console.Write(String.Join(",", numbers));
            Console.WriteLine();
            MaxHeap.Heapify(numbers);
            Console.Write(String.Join(",", numbers));

        }

        private static void HeapSort()
        {
            var heap = new Heap();
            int[] numbers = { 1, 10, 32, 5, 4, 76, 82, 12, 9, 7 };
            foreach (var number in numbers)
            {
                heap.Insert(number);
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = heap.Remove();
            //}

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = heap.Remove();
            }
            Console.Write(string.Join(",", numbers));

        }

        public static void TestHeap()
        {
            var heap = new Heap();
            heap.Insert(10);
            heap.Insert(2);
            heap.Insert(11);
            heap.Insert(4);
            heap.Insert(22);
            var removedItem = heap.Remove();
            Console.WriteLine(removedItem);
        }
        private static void TestCircularLinkedList()
        {
            var cirLL = new CircularLinkedList();
            cirLL.AddLast(4);
            cirLL.AddLast(5);
            cirLL.AddLast(16);
            cirLL.AddLast(13);
            cirLL.Display();
            cirLL.AddFirst(14);
            cirLL.Display();
            cirLL.AddAny(10, 4);
            cirLL.Display();
            Console.WriteLine($"removed value is { cirLL.RemoveFirst()}");
            cirLL.Display();
            Console.WriteLine($"removed value is { cirLL.RemoveLast()}");
            cirLL.Display();
            Console.WriteLine($"removed value is {cirLL.RemoveAny(3)}");
            cirLL.Display();


        }

        private static void TestLinkedList()
        {

            var l = new LinkedListNode();

            l.InsertSorted(7);
            l.InsertSorted(4);
            l.InsertSorted(12);
            l.InsertSorted(5);
            l.Display();
            Console.WriteLine($"Size : {l.Length()}");

            //l.AddAny(20,3);
            //l.Display();
            //Console.WriteLine($"Size : {l.Length()}");

            var key = 20;
            Console.WriteLine($"{key} index is {l.Search(key)}");

            //l.RemoveFirst();
            //l.Display();
            //Console.WriteLine($"Size : {l.Length()}");

            //l.RemoveLast();
            //l.Display();
            //Console.WriteLine($"Size : {l.Length()}");

            //l.RemoveAny(2);
            //l.Display();
            //Console.WriteLine($"Size : {l.Length()}");

        }

        private static void TestDoublyLinkedList()
        {
            var l = new DoublyLinkedList();
            l.AddLast(3);
            l.AddLast(4);
            l.Display();
            l.AddFirst(5);
            l.Display();
            l.AddAny(32, 2);
            l.Display();
            //Console.WriteLine($"removed element :{l.RemoveFirst()}");
            //l.Display();
            //Console.WriteLine($"removed element :{l.RemoveLast()}");
            //l.Display();
            Console.WriteLine($"removed element :{l.RemoveAny(2)}");
            l.Display();

            //LinkedList<int> students = new LinkedList<int>()
            //{
            //    First = {  }
            //}


        }
    }
}
