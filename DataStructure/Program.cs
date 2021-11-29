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
            l.AddAny(20,3);
            l.Display();
            Console.ReadKey();
        }
    }
}
