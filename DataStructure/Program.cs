using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.HashTableSolutions;
using DataStructure.HeapSolutions;
using DataStructure.LinkedList;
using DataStructure.LinkedList.CircularLinkedList;
using DataStructure.LinkedList.DoublyLinkedList;
using DataStructure.Queues;
using DataStructure.Searching;
using DataStructure.Sorting;
using DataStructure.Stack;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCircularLinkedList();
            //Sorting();
            //TestDoublyLinkedList();
            //TestStack();
            //TestQueue();
            //Searching();
            //Recursion recursion = new Recursion();
            //Console.WriteLine(recursion.Factorial(0));
            //TestHashTable();

            TestHeap();
            Console.ReadKey();
        }

        public static void TestHeap()
        {
            var heap = new Heap();
            heap.Insert(10);
            heap.Insert(2);
            heap.Insert(11);
            heap.Insert(4);
            heap.Insert(22);
            heap.Remove();
            Console.WriteLine("Done");
        }

        private static void TestHashTable()
        {

            //var statement = "Hi This is ALi".ToCharArray();
            //Console.WriteLine(Problems.GetFirstRepeatedChar(statement));

            var table = new HashTable();
            table.Put(4,"Saba");
            table.Put(3,"Lagha");
            table.Put(12,"Sohrab");
            table.Put(4,"SS");
            table.Remove(12);
            Console.WriteLine(table.Get(4));
        }
        private static void Searching()
        {
            int[] arr = new[] { 1, 5, 3, 9, 33, 8 };
            int[] sortedArr = new[] { 1, 2, 4, 6, 10, 16, 22 };
            //LinearSearch search = new LinearSearch();
            BinarySearch search = new BinarySearch();
            //Console.WriteLine(search.Search(sortedArr, 7, 9));
            //Console.WriteLine(search.Search(sortedArr, 7, 10));
            Console.WriteLine(search.RecSearch(sortedArr, 0, sortedArr.Length, 16));
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
            int[] arr = { 2, 5, 4, 8, 12, 1, 10, 19, 433, 5 };
            //SelectionSort.Sort(arr,arr.Length);
            //Insertion.Sort(arr,arr.Length);
            //Bubble.Sort(arr,arr.Length);
            Shell.Sort(arr, arr.Length);

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
