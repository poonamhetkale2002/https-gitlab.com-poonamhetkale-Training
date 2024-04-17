using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WiproCollections
{
     class StackDemo
    {
        static void Main(string[] args)
        {
            //Stack Creation
            Stack s= new Stack();
            //push elements
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            //Display stack elements
            foreach(int i in s)
                    Console.WriteLine(i);

            //pop topmost item
            Console.WriteLine(s.Pop()+" Removed Successfully");
            Console.WriteLine("Elements after pop:");
                foreach(int i in s)
                    Console.WriteLine(i);

            //display topmost item
            Console.WriteLine("Top most element is :" + s.Peek());

           Console.ReadLine();
        }
    }
}
