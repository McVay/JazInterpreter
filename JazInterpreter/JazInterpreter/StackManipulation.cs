using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaz_Interpreter;

namespace JazInterpreter
{
    public static class StackManipulation
    {
        public static void Push(int input)
        {
            Program.ExecutionStack.Push(input);
        }
        public static int Pop()
        {
            return Program.ExecutionStack.Pop();
        }
        public static void Copy()
        {
            Program.ExecutionStack.Push(Program.ExecutionStack.Peek());
        }
    }
}
