using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCollections
{
    internal class Queue
    {
        Queue<int> queue=new Queue<int>();
        public void QueueMethods()
        { 
            //Enqueue Method

            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            Console.WriteLine("Queue after adding elements");
            Display();

            //Dequeue Method

            queue.Dequeue();

            Console.WriteLine("Queue after removing elements");
            Display();

            //Peek Method

            int front = queue.Peek();

            Console.WriteLine("Returns front most element " + front);
            Display();

            //CountMethod

            int count = queue.Count();
            Console.WriteLine("Count of queue " + count);
            Display();

            //Contaims Method
            Console.WriteLine("Queue contains 6 ?" + queue.Contains(6));

        }
        public void Display()
        {
            foreach (int elements in queue)
            {
                Console.Write(elements + " - ");
            }

        Console.WriteLine();
        }
    }
}
