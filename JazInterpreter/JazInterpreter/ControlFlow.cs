using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    public static class ControlFlow
    {
        public static void Halt()
        {
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }

        public static void Goto(string value)
        {
            int lineNumber;
            if(Program.LabelTable.TryGetValue(value, out lineNumber))
            {
                Program.LineCount = lineNumber;
            }
        }
        public static void GoFalse(string value)
        {
            int val1 = (int)StackManipulation.Pop();
            if(val1 == 0)
            {
                Goto(value);
            }
        }
        public static void GoTrue(string value)
        {
            int val1 = (int)StackManipulation.Pop();
            if (val1 == 1)
            {
                Goto(value);
            }
        }
    }
}
