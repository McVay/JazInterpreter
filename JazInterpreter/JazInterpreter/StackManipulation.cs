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
        public static void Push(object input)
        {
            Program.ExecutionStack.Push(input);
        }
        public static object Pop()
        {
            return Program.ExecutionStack.Pop();
        }
        public static void Copy()
        {
            Program.ExecutionStack.Push(Program.ExecutionStack.Peek());
        }

        public static void Set()
        {
            int value = (int) Pop();
            string varname = (string) Pop();
            Program.MemoryTable[varname] = value;
        }

        public static void RValue(string instructionValue)
        {
            int value;
            if (Program.MemoryTable.TryGetValue(instructionValue, out value))
            {
                Push(value);
            }
            else
            {
                Push(0);
            }
        }

        public static void LValue(string instructionValue)
        {
            Program.MemoryTable.Add(instructionValue, 0);
            Push(instructionValue);
        }
    }
}
