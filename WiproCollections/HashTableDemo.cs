using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WiproCollections
{
     class HashTableDemo
    {
        static void Main(string[] args)
        {
            // For searching elemenst random;y /dynamicaly
            // use a structure that uses key value pair

            //Create hashtable
            Hashtable ht= new Hashtable();
            //adding elements
            ht[1] = "Poonam";
            ht[2] = "Komal";
            ht[3] = "Kirti";
            ht[4] = "Pratiksha";
            //Display elements
            for(int i=1;i<=ht.Count;i++)
            {
                Console.WriteLine("key:"+i+" value:"+ht[i]);
            }


            foreach(int key in ht.Keys)
                Console.WriteLine($"Roll:{key} and Name:{ht[key]}");
            Console.ReadLine();
        }
    }
}
