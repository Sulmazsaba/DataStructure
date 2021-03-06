using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.GraphsSolutions.Weighted;
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
