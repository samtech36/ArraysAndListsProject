using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Create an int array and populate it with numbers 1-10 (DONE)
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create a list of type int(DONE)
             * Name the list "evens"
             */
            List<int> evens = new List<int>();


            /* Create another list of type int (DONE)
             * Name the list "odds"
             */
            List<int> odds = new List<int>();


            /* Using either a foreach or for loop,(DONE)
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */

            for (int i = 0; i < numbers.Length; i++)
            {
             if (numbers[i] % 2 == 0)
             {
              evens.Add(numbers[i]);
             }

             else
             {
              odds.Add(numbers[i]);
             }
            }



            /* Using a foreach loop, (DONE)
             * display the numbers in your "evens" list
             */
            Console.WriteLine("The numbers in evens list are: ");
            foreach (int even in evens)
            {
             Console.WriteLine(even);
             
            }
            
            
            


            /* Using a for loop, (DONE)
             * display the numbers in your "odds" list
             */
            Console.WriteLine("The numbers in odds list are: ");
            for (int i = 0; i < odds.Count; i++)
            {
             Console.WriteLine(odds[i]);
            }

        }
    }
}
