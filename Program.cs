using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCollections
{
    public class Program
    { 
        public static void Main(string[] args) 
        {
            // Methods of ArrayList
            Array_List p1 = new Array_List();
            p1.ArrayListMethod();
            Console.WriteLine();


            // Methods of LinkedList
            LinkedList p2 = new LinkedList();
            p2.LinkListMethods();
            Console.WriteLine();


            // Methods of Stack
            Stacks p3 = new Stacks();
            p3.StackMethods();
            Console.WriteLine();

            // Methods of Queue
            Queue p4 = new Queue();
            p4.QueueMethods();
            Console.WriteLine();

            // Methods of List
            List p5 = new List();
            p5.ListMethod();
            Console.WriteLine();
        }
    
    
    }
}