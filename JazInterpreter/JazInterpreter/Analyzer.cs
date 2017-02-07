using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaz_Interpreter;

namespace JazInterpreter
{
    class Analyzer
    {
        public static bool Analyze(List<string> lines)
        {
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                var splitLine = trimmedLine.Split(' ');

                var head = splitLine[0].Trim();
                var tail = trimmedLine.Substring(splitLine[0].Length).Trim();

                if (string.IsNullOrEmpty(head)) continue;

                if (head.Equals("label"))
                {
                    //store label somewhere
                    Program.symbolTable.Add(new KeyValuePair<string, string>(head, tail));
                }
                else
                {
                    Program.symbolTable.Add(new KeyValuePair<string, string>(head, tail));
                }
            }
            return true;
        }
    }
}
