using System;
using System.Collections.Generic;
using System.Globalization;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var  intsArray = new int[10] { 1,2,3,4,5,6,7,8,9,10};


            //Console.WriteLine(intsArray);
                


            // Create two Lists of type int.
             //Name one List "evens"
              var evens = new List<int>();
            //Name the other List "odds"
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 1; i < intsArray.Length; i ++)
            {
                if( i% 2 == 0)
                {
                    evens.Add(i);
                }
                else if(i% 2 != 0)
                {
                    odds.Add(i);
                }
                //Console.WriteLine(evens);
                //Console.WriteLine(odds);
            }
            
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }
            foreach (int i in odds)
            {
                Console.WriteLine(i);
            }


        }
    }
}
