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
            //Probably should put a peek method into StackManipulation, or should we just pop when we print?
            Console.WriteLine(Program.ExecutionStack.Peek());
        }
        public static void Show(string output)
        {
            Console.WriteLine(output);
        }
    }
}
