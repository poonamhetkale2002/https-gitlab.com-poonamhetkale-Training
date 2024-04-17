using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
      class Test
        {
            static string batch = "B001"; //static variable should be declare in the scope of class
            //  
        public static void Main(string[] args)
            {

                int x = 20;
                const int y = 200;
               // y=y+1;    //Constant value cannot be change.
           
                // format string
                string strFormat = String.Format("{0, -20} {1, -14}", "Programiz", "C# Programming");
                Console.WriteLine(strFormat);

                char[] chars = new char[] { 'A', 'B', 'C', 'D' };
                string sen = new string(chars);
                Console.WriteLine(sen);
                char[] char2 = sen.ToCharArray();

                Console.WriteLine(char2);

                Console.WriteLine(string.Concat("Hello", " ", "Bye"));
                Console.WriteLine(sen.Substring(0, 1));

                Console.ReadLine();
            }
        }
}
