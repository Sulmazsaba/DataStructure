using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.LinkedList;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new LinkedListNode();

            l.AddLast(7);
            l.AddLast(4);
            l.AddLast(12); 
            l.AddFirst(4);
            l.Display();
            Console.WriteLine($"Size : {l.Length()}");

            l.AddAny(20,3);
            l.Display();
            Console.WriteLine($"Size : {l.Length()}");

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



            Console.ReadKey();
        }
    }
}
