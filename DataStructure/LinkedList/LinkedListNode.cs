﻿using System;
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

       public void AddLast(int element)
       {
           Node newest = new Node(element, null);
           if (IsEmpty())
               head = newest;
           else
           {
               tail.next = newest;
           }

           tail = newest;
           size++;

       }

       public void AddFirst(int element)
       {
           var newest = new Node(element, null);
           if (IsEmpty())
           {
               head = newest;
               tail = newest;

           }
           else
           {
               newest.next = head;
               head = newest;
           }

           size++;
       }

       public void AddAny(int element, int position)
       {
           if (position == 0 || position >= size)
           {
               Console.WriteLine("Invalid Position");
               return;
           }

           var newest = new Node(element, null);

           // traversing the linkedlist
           Node p = head;
           int i = 1;
           while (i<position-1)
           {
               p = p.next;
               i++;
           }

           newest.next = p.next;
           p.next = newest;
           size++;

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
