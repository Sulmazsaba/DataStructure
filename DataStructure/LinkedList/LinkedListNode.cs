using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
   public class LinkedListNode
   {
       private Node head;
       private Node tail;
       private int size;

       public LinkedListNode()
       {
           head = null;
           tail = null;
           size = 0;
       }

       public int Length()
       {
           return size;
       }

       public bool IsEmpty()
       {
           return size == 0;
       }

       public void AddLast(int e)
       {
           Node newest = new Node(e, null);
           if (IsEmpty())
               head = newest;
           else
           {
               tail.next = newest;
           }

           tail = newest;
           size++;

       }

       public void AddFirst(int e)
       {

       }

       public void Display()
       {
           Node p = head;
           while (p!=null)
           {
               Console.Write(p.element + " --> ");
               p = p.next;
           }
           Console.WriteLine();

       }
   }
}
