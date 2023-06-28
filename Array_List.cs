using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSCollections
{
    internal class Array_List
    {
       ArrayList list = new ArrayList();

        public void ArrayListMethod()
        { 
            //Add Method

            list.Add(2);
            list.Add(5);
            list.Add(8);
            list.Add(9);
            list.Add(1);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("The Array List after adding elements : ");
            Display();

            //Remove Method

            list.Remove(8);
            list.Remove(1);

            Console.WriteLine("The Array List after removing element : ");
            Display();

            //Sort Method

            list.Sort();

            Console.WriteLine("Sorted Array List");
            Display();

            //Insert Method

            list.Insert(0, 10);

            Console.WriteLine("Inserting element at 1st position");
            Display();

            //Remove at particular index

            list.RemoveAt(1);

            Console.WriteLine("Removes element from given index");
            Display();

            //Count of List

            int count = list.Count;

            Console.WriteLine($"Count of Array List {count}");
            Display();

            
        }
       public void Display()
        {
            foreach (var elements in list)
            {
                Console.WriteLine(elements + " ");
            }
        }
    }
}
