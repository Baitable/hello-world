using System;
using System.Runtime.InteropServices;

namespace hello_world
{
    class Program
    {

        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        // Entry point of application.
        static void Main(string[] args)
        {
            // Set the title of the application.
            Console.Title = "Hello World!";

            // Make program unresizeable due to messing up the console display because of resizing.
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);
            DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
            DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);

            // The bit which prints 'Hello World!'.
            Console.WriteLine(Environment.NewLine +  "  Hello World!" + Environment.NewLine + "      by Baitable.");

            // Keep the program alive so that you can read the previous message.
            while (true) ;
        }
    }
}
