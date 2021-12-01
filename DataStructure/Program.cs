using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.LinkedList;
using DataStructure.LinkedList.CircularLinkedList;
using DataStructure.Sorting;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCircularLinkedList();

            Sorting();

            Console.ReadKey();
        }

        private static void Sorting()
        {
            int[] arr = {2, 5, 4, 8, 12, 1, 10, 19, 433, 5};
            //SelectionSort.Sort(arr,arr.Length);
            Insertion.Sort(arr,arr.Length);

            foreach (var i in arr)
            {
                Console.Write(i+"-->");
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
    }
}
