using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCollections
{
    internal class Stacks
    {
        Stack<int> stack = new Stack<int>();
        public void StackMethods()
        {
            //PUSH Method
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);

            Console.WriteLine("Stack with push method");
            Display();

            //POP Method
            stack.Pop();

            Console.WriteLine("Stack with pop method");
            Display();

            //Peek Method
            int topElement= stack.Peek();

            Console.WriteLine("Returns top most element " + topElement);
            Display();

            //CountMethod
            int count=stack.Count();
            Console.WriteLine("Count of stack " + count );
            Display();

            //Contaims Method
            Console.WriteLine("Stack contains 6 ?" + stack.Contains(6));

        }

        public void Display()
        {
            foreach (var item in stack) 
            {
                Console.WriteLine(item + " | ");
            
            }
            Console.WriteLine();
        }
    }
}
