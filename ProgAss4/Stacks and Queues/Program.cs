/*
Author:     Michael Hart
Date:       10/27/19
CTEC 135:   Microsoft Software Development with C#
<Module 5, Programming Assignment 4, Problem 2>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            // declare and initialize a stack with the numbers 1 - 5 
            // using initialization syntax
            Stack<int> stackOfInts = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stackOfInts.Push(i+1);
            }

            // demonstrate use of the enumerator to print out the members
            // in the stack, i.e. write a foreach loop

            // header
            Console.WriteLine("***** Printing Stack *****\n");

            foreach (int item in stackOfInts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // print a peek at the top member in the stack
            Console.WriteLine("***** Stack Peek *****\n");
            Console.WriteLine(stackOfInts.Peek());
            Console.WriteLine();

            // write a loop that pops the elements off of the stack and 
            // prints each

            // header
            Console.WriteLine("***** Popping off stack *****\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} has been popped off the stack", stackOfInts.Pop()); 
            }
            Console.WriteLine();
            #endregion

            #region Queue
            // header
            Console.WriteLine("***** Printing Queue *****\n");

            // declare a queue
            Queue<int> myQueue = new Queue<int>();

            // initialize the queue with the numbers 1-5 using a for loop
            for (int i = 0; i < 5; i++)
            {
                myQueue.Enqueue(i + 1);
            }

            // demonstrate use of the enumerator to print out the members
            // in the queue, i.e. write a foreach loop
            foreach (int item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // print a peek at the top member in the stack           
            Console.WriteLine("***** Queue Peek *****\n");
            Console.WriteLine("Queue Peek: {0}", myQueue.Peek());
            Console.WriteLine();

            // write a loop that dequeues the elements from the stack
            // and prints each
            Console.WriteLine("***** Dequeued Elements *****\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} has been dequeued from the stack", myQueue.Dequeue());
            }
            Console.WriteLine();
            #endregion
        }
    }
}
