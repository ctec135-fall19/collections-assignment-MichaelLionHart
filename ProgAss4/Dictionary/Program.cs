/*
Author:     Michael Hart
Date:       10/27/19
CTEC 135:   Microsoft Software Development with C#
<Module 5, Programming Assignment 4, Problem 3>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a dictionary and initialize it to create 3 entries
            // (1, "one"), (2, "two"), and (3, "three").  Use a combination
            // of initialization syntax, Add() and [] in your initialization code.
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            // add an additional entry: (99, "ninety-nine")
            myDictionary.Add(99, "ninety-nine");

            // show use of enumerator to see all entries.  Print both
            // the key and value
            Console.WriteLine("***** Printing Keys *****\n");
            foreach (int key in myDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            Console.WriteLine("***** Printing Values *****\n");
            foreach (string value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // reassign the value of 99 to "99" using indexing notation
            myDictionary[3] = "99";

            // print the new value using indexing notation
            Console.WriteLine("***** Printing Newly Indexed Value *****\n");           
            Console.WriteLine(myDictionary[3]);
            Console.WriteLine();

            // remove the 2 item and enumerate over the whole dictionary
            // to show it's gone
            myDictionary.Remove(2);
            Console.WriteLine("***** Printing Keys w/ Item Removed *****\n");
            foreach (int key in myDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            Console.WriteLine("***** Printing Values w/ Item Removed *****\n");
            foreach (string value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}
