namespace Day_5_Tasks
{
   class task1
    {
        /*
         * Create a C# console application that prompts the user for an integer 
         * and a double, then demonstrates both implicit and explicit conversion.
         * Display the results of conversion and any loss of data if it occurs.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer Value:");
                int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Double Value:");
                double d=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Integer:" + x + " \tDouble:" + d);
            Console.WriteLine("Integer-->double:"+Convert.ToDouble(x));
            Console.WriteLine("Double-->Integer:" + Convert.ToInt32(d));
            Console.ReadLine();
        }
    }
}
