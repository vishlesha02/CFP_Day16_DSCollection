using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCollections
{
    internal class LinkedList
    {
        LinkedList<int> list=new LinkedList<int>(); 
        public void LinkListMethods()
        {
            //Adding at First elements
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            list.AddFirst(6);
            list.AddFirst(7);

            Console.WriteLine("Linked list after adding elements ");
            Display();

            //Adding at Lat elements

            list.AddLast(1);
            list.AddLast(2);

            Console.WriteLine("Linked list after adding elements at last ");
            Display();

            //Removes Element
            list.Remove(5);

            Console.WriteLine("Linked list after removing element  ");
            Display();

            //Count of List

            int count = list.Count;

            Console.WriteLine($"Count of Array List {count}");
            Display();

            Console.WriteLine("Linked List Contains 1 ? " +  list.Contains(1));

        }

        public void Display()
        {
            foreach (int elements in list)
            { 
                Console.Write(elements + "=>");
            }
            Console.WriteLine();
        }
    }
}
