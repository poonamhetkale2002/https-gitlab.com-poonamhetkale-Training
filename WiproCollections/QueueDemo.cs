using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace WiproCollections
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            //create Queue
            Queue q = new Queue();
            //insert elements in queue
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            //Display queue elements
            Console.WriteLine("Queue Elements:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue(); //FIFO Manner
            Console.WriteLine("Elements after Removing:");
            foreach (var item in q)
            {
                Console.WriteLine(item); 
            }            
            Console.ReadLine();
        }
    }
}
