using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCollections
{
    internal class List
    {
        List<int> list = new List<int>();

        public void ListMethod()
        { 
            //ADD Method

            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(11);
        
            Console.WriteLine("List after adding the elements ");
            Display();

            //Remove Method

            list.Remove(9);
            Console.WriteLine("List after removing the element ");
            Display();


            //Remove at particular index

            list.RemoveAt(1);

            Console.WriteLine("Removes element from given index");
            Display();

            //Count of List

            int count = list.Count;

            Console.WriteLine($"Count of List {count}");
            Display();


            //Sort Method

            list.Sort();

            Console.WriteLine("Sorted List");
            Display();
        }

        public void Display()
        {
            foreach (int element in list)
            { 
                Console.WriteLine(element + " ");
            }

            Console.WriteLine();
        }
    }
}
