using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JazInterpreter;

namespace Jaz_Interpreter
{
    class Program
    {
        public static Stack<object> ExecutionStack = new Stack<object>();
        public static List<KeyValuePair<string, string>> SymbolTable = new List<KeyValuePair<string, string>>();
        public static Dictionary<string, int> MemoryTable = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            //if (!(args.Length > 0))
            //{
            //    Console.WriteLine("You must provide a file path.");
            //    Environment.Exit(0);
            //}

            //Analyze
            //List<string> lines = File.ReadLines(args[0]) as List<string>;
            IEnumerable<string> lines = File.ReadLines("operatorsTest.jaz");
            var enumerable = lines as IList<string> ?? lines.ToList();
            if (enumerable.Any())
            {
                Analyzer.Analyze(enumerable.ToList());
                foreach (var line in SymbolTable)
                {
                    Executor.Execute(line);
                }
            }
        }
    }
}
