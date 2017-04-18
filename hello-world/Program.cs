using System;

namespace hello_world
{
    class Program
    {
        // Entry point of application.
        static void Main(string[] args)
        {
            // Set the title of the application.
            Console.Title = "Hello World!";
            // The bit which prints 'Hello World!'.
            Console.WriteLine(Environment.NewLine +  "  Hello World!" + Environment.NewLine + "      by Baitable.");
            // Keep the program alive so that you can read the previous message.
            while (true) ;
        }
    }
}
