using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JazInterpreter
{
    class Program
    {
        public static Stack<object> ExecutionStack = new Stack<object>();
        public static List<KeyValuePair<string, string>> SymbolTable = new List<KeyValuePair<string, string>>();
        public static Dictionary<string, int> MemoryTable = new Dictionary<string, int>();
        public static Dictionary<string, int> MemoryTableCopy = new Dictionary<string, int>();
        public static Dictionary<string, int> LabelTable = new Dictionary<string, int>();

        public static int LineCount = 0;

        static void Main(string[] args)
        {
            if (!(args.Length > 0))
            {
                Console.WriteLine("You must provide a file path.");

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(1);
            }

            //IEnumerable<string> lines = File.ReadLines("factProc.jaz");
            IEnumerable<string> lines = File.ReadLines(args[0]);
            var enumerable = lines as IList<string> ?? lines.ToList();

            if (enumerable.Any())
            {
                //Analyze any line that isn't just whitespace
                Analyzer.Analyze(enumerable.Where(x => !String.IsNullOrWhiteSpace(x)).ToList()); 
                while(LineCount < SymbolTable.Count)
                {
                    Executor.Execute(SymbolTable[LineCount]);
                    LineCount++;
                }
            }
        }
    }
}
