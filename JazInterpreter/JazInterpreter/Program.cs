using System;
using System.Collections.Generic;
using System.IO;

namespace Jaz_Interpreter
{
    class Program
    {
        private static Stack<int> _stack = new Stack<int>();
        private static KeyValuePair<string, string> _symbolTable = new KeyValuePair<string, string>();

        static void Main(string[] args)
        {
            if (!(args.Length > 0))
            {
                Console.WriteLine("You must provide a file path.");
                Environment.Exit(0);
            }

            //Analyze
            var lines = File.ReadLines(args[0]);
            foreach (var line in lines)
            {

            }
        }
    }
}
