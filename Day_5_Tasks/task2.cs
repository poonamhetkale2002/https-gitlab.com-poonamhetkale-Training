using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Tasks
{
    class task2
    {
        /*
         * Design a C# program with a method that attempts to access a local variable 
         * outside its scope, a constant, and a static variable. Document the
         * results in comments within the code explaining why each access either 
         * succeeds or fails.
         */
        const int y = 10;

        // Static variable
        static int x = 20;

        static void Main(string[] args)
        {
            // Local variable
            int localVar = 30;

            AccessLocalVariable(localVar); // access local variable
            AccessConstant(); // access constant
            AccessStaticVariable(); //access static variable
        }

        static void AccessLocalVariable(int localVar)
        {
            // Attempting to access local variable outside its scope
            // Uncommenting the line below will result in a compilation error:
            Console.WriteLine(localVar);
            // Local variables are only accessible within the block they are declared in (in this case, within Main method)
        }

        static void AccessConstant()
        {
            // Accessing constant
            // Constants are accessible within the same class or namespace
            Console.WriteLine("Constant value: " + y);
        }

        static void AccessStaticVariable()
        {
            // Accessing static variable
            // Static variables are accessible within the same class 
            Console.WriteLine("Static variable value: " + x);
        }
    }
}
