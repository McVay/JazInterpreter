using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaz_Interpreter;

namespace JazInterpreter
{
    public static class Output
    {
        public static void Print()
        {
            Console.WriteLine(Program.ExecutionStack.Peek());
        }
        public static void Show(string output)
        {
            Console.WriteLine(output);
        }
    }
}
