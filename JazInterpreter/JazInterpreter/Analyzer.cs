using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    class Analyzer
    {
        public static bool Analyze(List<string> lines)
        {
            for (var i = 0; i < lines.Count; i++)
            {
                var trimmedLine = lines[i].Trim();
                var splitLine = trimmedLine.Split(' ');

                var head = splitLine[0].Trim();
                var tail = trimmedLine.Substring(splitLine[0].Length).Trim();

                if (string.IsNullOrEmpty(head)) continue;

                if (head.Equals("label"))
                {
                    Program.LabelTable.Add(tail, i);
                    Program.SymbolTable.Add(new KeyValuePair<string, string>(head, tail));
                }
                else
                {
                    Program.SymbolTable.Add(new KeyValuePair<string, string>(head, tail));
                }
            }
            return true;
        }
    }
}
