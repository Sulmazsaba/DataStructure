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
using DataStructure.TreeSolutions;
using DataStructure.TriesSolution;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCircularLinkedList();
            Sorting();
            //TestDoublyLinkedList();
            //TestStack();
            //TestQueue();
            ////Searching();
            //Recursion recursion = new Recursion();
            //Console.WriteLine(recursion.Factorial(0));
            //TestHashTable();
            //TestHeap();
            //HeapSort();
            //TestHeapify();
            //TestTree();
            //TestAVLTree();
            //TestTrie();
            //TestGraph();
            //TestDirectedGraph();
            Console.ReadKey();
        }

        private static void TestDirectedGraph()
        {
            WeightedGraph graph = new WeightedGraph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddEdge("A","B",2);
            graph.AddEdge("B","C",3);
            graph.AddEdge("C", "A", 10);
            Console.WriteLine(graph.GetShortestDistance("A","C"));
            Console.WriteLine(graph.HasCycle());
            graph.Print();
        }

        private static void TestGraph()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A","B");
            graph.AddNode("C");
            //graph.AddEdge("C","A");
            graph.AddNode("D");
            //graph.AddEdge("B","D");
            //graph.AddEdge("B", "C");
            //graph.Print();
            //graph.RemoveNode("Jack");
            //Console.WriteLine($"removed node Jack");
            //graph.RemoveEdge("John", "Sub");
            //graph.RemoveNode("Jack");
            //graph.TraverseDepthFirst("B");
            //graph.Print();
            //graph.TopologicalSort();
            Console.WriteLine(graph.HasCycle());
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

        private static void TestTree()
        {
            Tree tree = new Tree();
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(1);
            tree.Insert(15);
            tree.Insert(6);

            Tree tree2 = new Tree();
            tree2.Insert(4);
            tree2.Insert(10);
            tree2.Insert(1);
            tree2.Insert(15);
            //tree2.Insert(6);

            //Console.WriteLine($"Pre-Order Traversal : ");
            //tree.TraversePreOrder();

            //Console.WriteLine(tree.Height());
            //Console.WriteLine(tree.Find(1));
            //Console.WriteLine(tree.MinValue());

            //Console.WriteLine(tree.Equals(tree2));
            //Console.WriteLine(tree.IsBinarySearchTree());
            tree.GetNodeAtDistance(1);
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

        private static void TestHashTable()
        {

            //var statement = "Hi This is ALi".ToCharArray();
            //Console.WriteLine(Problems.GetFirstRepeatedChar(statement));

            var table = new HashTable();
            table.Put(4, "Saba");
            table.Put(3, "Lagha");
            table.Put(12, "Sohrab");
            table.Put(4, "SS");
            table.Remove(12);
            Console.WriteLine(table.Get(4));
        }
        private static void Searching()
        {
            int[] arr = new[] { 1, 5, 3, 9, 33, 8 };
            int[] sortedArr = new[] { 1, 2, 4, 6, 10 };
            //LinearSearch search = new LinearSearch();
            BinarySearch search = new BinarySearch();
            //Console.WriteLine(search.Search(sortedArr, 7, 9));
            //Console.WriteLine(search.Search(sortedArr, 7, 10));
            Console.WriteLine(search.RecSearch(sortedArr, 0, sortedArr.Length, 5));
        }

        private static void TestQueue()
        {
            QueuesLinkedList que = new QueuesLinkedList();
            //QueuesArray que = new QueuesArray(5);
            que.Enqueue(5);
            que.Enqueue(10);
            que.Enqueue(15);
            que.Enqueue(2);
            que.Display();
            que.Dequeue();
            que.Display();

        }

        private static void TestStack()
        {
            StacksLinkedList stc = new StacksLinkedList();
            //StacksArray stc = new StacksArray(6);
            stc.Push(3);
            stc.Push(12);
            stc.Push(1);
            stc.Display();
            Console.WriteLine($"pop element : {stc.Pop()}");
            stc.Display();
            stc.Push(9);
            stc.Display();
        }

        private static void Sorting()
        {
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 19, 433 };
            //SelectionSort.Sort(arr,arr.Length);
            //Insertion.Sort(arr,arr.Length);
            Bubble.Sort(arr);
            //Shell.Sort(arr, arr.Length);

            foreach (var i in arr)
            {
                Console.Write(i + "-->");
            }
            Console.WriteLine();
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
