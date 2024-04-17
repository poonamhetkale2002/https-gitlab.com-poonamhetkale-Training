using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproCollections
{
    /*
     Write a program to perform following functions in integer array(MODULAR APPROACH)
        ARRAY SHUD BE SORTED FIRST
        1. insert element,
        2. delete element
        3. update element
        4. reverse elements of an integer array
        5. search element 
             1. Linear Search
             2. Binary Search
        6.Sort Array (Use Any Brute Force Algo) - Use Bubble Sort
    */
    class ArrayOperations
    {
        List<int> a = new List<int>();
        //insert elements
        void insert(int x)
        {
            a.Add(x);
            Console.WriteLine(x + " added Successfully.");
        }

        //Delete elements
        void delete(int item)
        {
            int flag = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == item)
                {
                    a.Remove(item);
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine(item + " Removed Successfully.");
            }
            else
            {
                Console.WriteLine(item + " Does not exists.");
            }
        }
        
        void update(int pos,int item)
        {
            void update(int pos, int item)
            {
                if (pos < a.Count && pos >= 0)
                {
                    a[pos] = item;
                    Console.WriteLine(item + " Updated successfully.");
                }
                else
                {
                    Console.WriteLine("invalid position.");
                }
            }
        }

        //Display elements.
        void display()
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //reverse elements
        void reverse()
        {
            Console.WriteLine("reverse elements of an integer array:");
            for (int i = a.Count-1; i>=0 ; i--)
            {
                Console.WriteLine(a[i]);
            }
        }

        //Linear Searching
        void linear_Search(int item)  //without sorting
        {
            int flag = 0;
            for(int i=0;i<a.Count; i++)
            {
                if (a[i]==item)
                {
                    flag = 1; break;
                }
            }
            if (flag==1)
            {
                Console.WriteLine(item + " is found.");
            }
            else
            {
                Console.WriteLine(item + " is not found.");
            }
        }

        //Binary_Search

        void binary_search(int item)
        {
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
            int left = 0;
            int right=a.Count-1;
            int flag = 0;
            while(left <= right)
            {
                int mid=left+(right-left)/2;
                if (a[mid]==item)
                {
                    flag = 1; break;
                }
                if (a[mid]<item)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
               }
            if (flag == 1)
            {
                Console.WriteLine(item + " is found.");
            }
            else
            {
                Console.WriteLine(item + " is not found.");
            }
        }

        //Bubble sorting
        void bubble_Sort()
        {
            for(int i=0;i<a.Count;i++)
            {
                for(int j=0;j<a.Count-1;j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Sorted elements are:");
            display();
          }
        
        static void Main(string[] args)
        {
            ArrayOperations p = new ArrayOperations();
            int ch;
            do
            {
                Console.WriteLine("Enter Yout Choice:\n 0.Exit 1.Insert 2.Delete 3.Display 4.Update ");
                Console.WriteLine("\n 5.Reverse 6.Linear_search 7.Bubble_sort 8.Binary_Search ==>");
               ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter int Element to add in array: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        p.insert(x);
                        break;
                    case 2:
                        Console.WriteLine("Enter Element to delete element:");
                        int z = Convert.ToInt32(Console.ReadLine());
                        p.delete(z);
                        break;
                    case 3:
                        p.display();
                        break;
                    case 4:
                        Console.WriteLine("Enter position to update element:");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Element to Update:");
                        int item = Convert.ToInt32(Console.ReadLine());
                        p.update(pos, item);
                        break;
                    case 5: p.reverse(); break;
                    case 6:Console.WriteLine("Enter Element to Search:");
                            int y= Convert.ToInt32(Console.ReadLine());
                            p.linear_Search(y); break;
                    case 7:p.bubble_Sort(); break;

                    case 8:
                        Console.WriteLine("Enter Element to Search:");
                        int m = Convert.ToInt32(Console.ReadLine());
                        p.binary_search(m); break;
                    case 0:break;

                    default:
                        Console.WriteLine("Invalid Choice .");
                        break;
                }
            }
            while (ch != 0);
            Console.ReadLine();
        }
    }
}
