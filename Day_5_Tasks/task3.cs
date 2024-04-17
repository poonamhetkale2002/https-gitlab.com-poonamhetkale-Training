using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Tasks
{
    /*
     * Write a C# application that uses nested if-else statements to classify
     * a number as positive, negative, or zero, and then iterates from 
     * that number to zero using a for loop, printing each number to the console.
     */
    class task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any number:");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                Console.WriteLine(n + " is zero number");
            else if (n > 0)
            {
                Console.WriteLine(n + " is Positive number.");
                Console.WriteLine("Numbers from " + n + " to 0:");
                for (int i = n; i >= 0; i--)
                    Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(n + " is negative number.");
                Console.WriteLine("Numbers from " + n + " to 0:");
                for (int i = n; i <= 0; i++)
                    Console.WriteLine(i);
            }            
            Console.ReadLine();
        }
    }
}
