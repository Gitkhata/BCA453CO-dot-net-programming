using System;
namespace BoCA
{
    class Program
    {
        // Main function, execution entry point of the program  
        static void Main(string[] args) // string type parameters  
        {
            // Command line arguments  
            Console.WriteLine("Arg length: " + args.Length);
            Console.WriteLine("Given arguments:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
        }
    }
}