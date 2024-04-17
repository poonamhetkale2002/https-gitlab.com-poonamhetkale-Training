using System.Collections;

namespace WiproCollections
{
   class Array
    {
        static void Main(string[] args)
        {
            //Dynamic Size array creation
            ArrayList list = new ArrayList();
            //insert elements in array
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            //display array elements
            Console.WriteLine("Array Elements:");
            //for(int i = 0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Insert
            list.Insert(4,100);
            Console.WriteLine("Elements after inserting:");
            foreach (var item in list)
               Console.WriteLine(item);

            //remove direct specific element
            list.Remove(100);
            Console.WriteLine("Elements after Removing:");
            foreach (var item in list)
                Console.WriteLine(item);

            //remove specific element by position
            list.RemoveAt(1);
            Console.WriteLine("Elements after Removing:");
            foreach (var item in list)
                Console.WriteLine(item);

            // ArrayList is one class 
            // It allows to perform insert delete anywhere
            // when you want to acheive FIFO
            // go with queue

            Console.ReadLine();
        }
    }
}
