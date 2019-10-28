/*
Author:     Michael Hart
Date:       10/27/19
CTEC 135:   Microsoft Software Development with C#
<Module 5, Programming Assignment 4, Problem 1>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple array
            // header
            Console.WriteLine("***** Simple Array *****\n");

            // Create an array of int of size 5
            int[] myArray = new int[5];

            // use a for loop to initialize it to the numbers 11 - 15
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 11;
            }

            // use a foreach loop to print out the values in the array
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region List<T>
            // header
            Console.WriteLine("***** List<T> *****\n");

            // create a list of int
            List<int> myList = new List<int>();

            // use a for loop to initialize the list to the numbers 21 - 25
            for (int i = 0; i < 5; i++)
            {
                myList.Add(i + 21);
            }

            // use a foreach loop to print out the values in the list
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // update the values in the list to 31 - 35 using indexing           
            Console.WriteLine("***** Updated Values *****\n");
            myList[0] = 31;
            myList[1] = 32;
            myList[2] = 33;
            myList[3] = 34;
            myList[4] = 35;

            // repeat the print using a for loop and indexing
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
