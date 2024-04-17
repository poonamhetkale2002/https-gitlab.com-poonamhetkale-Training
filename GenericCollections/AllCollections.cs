using System.Collections.Generic;
namespace GenericCollections
{
    class AllCollections
    {
        static void Main(string[] args)
        {
            // ArrayList is replaced with List
            //Type Safe
            List<int> x = new List<int>();
             x.Add(1);
            x.Add(2);
            x.Add(3);
            Console.WriteLine("List Elements are:");
            foreach (int i in x)
                Console.WriteLine(i);
            //All functions are same as ArrayList Collection.

            Console.WriteLine("Queue Elements:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Poonam");
            queue.Enqueue("Komal");
            foreach(int i in x)
                Console.WriteLine(i);
            //All functions are same as Queue Collection.

            Console.WriteLine("Stack Elements:");
            Stack<float> st = new Stack<float>();
            st.Push(1.0f);
            st.Push(1.0f);
            foreach(int i in x)
                Console.WriteLine(i);
            //All functions are same as Stack Collection.


            // HashTable is replace with DIctionary
            Console.WriteLine("Dictionary Elements are:");
            Dictionary<int, int> Marks = new Dictionary<int, int>();
            Marks[1] = 90;
            Marks[2] = 98;
            for(int i = 1; i <=Marks.Count; i++)
                Console.WriteLine("Rollno:"+i+" Marks:"+Marks[i]);
            //All functions are same as Hashtable Collection.

            Console.ReadLine();
        }
    }
}
