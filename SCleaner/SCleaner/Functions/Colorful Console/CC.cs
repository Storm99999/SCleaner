using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCleaner.Functions.Colorful_Console
{
    class CC
    {
        public static void WriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Cleaner");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("] " + message + "\n");
        }
        public static void WriteLineSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message + "\n");
        }
        public static void WriteLineError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message + "\n");
        }
    }
}
