using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Chain of Responsibility *****");
            Console.WriteLine("\n");
            Console.WriteLine("***** Link 1 - Authentication *****");
            Console.WriteLine("\n");
            Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("***** Link 2 - Authorization *****");
            Console.WriteLine("\n");
            Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("***** Link 3 - Validation *****");
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
