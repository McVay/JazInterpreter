using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JazInterpreter;

namespace Jaz_Interpreter
{
    class Program
    {
        public static Stack<int> ExecutionStack = new Stack<int>();
        public static List<KeyValuePair<string,string>> SymbolTable = new List<KeyValuePair<string, string>>();

        static void Main(string[] args)
        {
            if (!(args.Length > 0))
            {
                Console.WriteLine("You must provide a file path.");
                Environment.Exit(0);
            }

            //Analyze
            List<string> lines = File.ReadLines(args[0]) as List<string>;

            if (lines != null && lines.Count > 0)
            {
                Analyzer.Analyze(lines);
                foreach (var line in lines)
                {
                    //execute
                }
            }
        }
    }
}
