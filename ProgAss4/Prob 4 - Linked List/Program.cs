/*
Author:     Michael Hart
Date:       10/27/19
CTEC 135:   Microsoft Software Development with C#
<Module 5, Programming Assignment 4, Problem 4>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList use
            // Demonstrate use of constructor taking an IEnumerable object. 
            // Create a string array having the first 5-10 words of your 
            // favorite nursery rhyme. Use it as the argument when 
            // constructing the LinkedList object.
            String[] jackArray = new string[] { "Jack,", "be", "nimble,", "Jack", "be", "quick," };
            LinkedList<string> myLinkedList = new LinkedList<string>(jackArray);

            // print out the rhyme on a single line
            Console.WriteLine("***** Initial Rhyme Print: *****");
            Console.WriteLine("Jack, be nimble, Jack be quick\n");

            // The traditional way to walk a linked list is to start at the head,
            // process the node, then set the node variable to the next node in 
            // the list. Create a node variable and walk the list to print out the 
            // values. The line printed should be the same as the one above.
            Console.WriteLine("***** Rhyme Print While Walking Linked List: *****");
            LinkedListNode<String> node = myLinkedList.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine("\n");

            // Remove a word from the middle of the list.  Print the list on a 
            // single line to demonstrate this
            Console.WriteLine("***** Rhyme Print With Word Removed: *****");
            LinkedListNode<String> nodeToRemove = myLinkedList.Find("nimble,");
            myLinkedList.Remove(nodeToRemove);
            node = myLinkedList.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine("\n");

            // Add the word back in and print the list again to demonstrate
            Console.WriteLine("***** Rhyme Print With Word Added Back In: *****");
            LinkedListNode<String> jackNode = myLinkedList.Find("Jack");
            myLinkedList.AddBefore(jackNode, nodeToRemove);
            node = myLinkedList.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine("\n");
            #endregion
        }
    }
}
