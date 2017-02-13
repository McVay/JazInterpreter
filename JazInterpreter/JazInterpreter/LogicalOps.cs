using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    public static class LogicalOps
    {
        public static void And()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 & val1);
        }
        public static void Or()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 | val1);

        }
        public static void Not()
        {
            // Not sure that is correct but works for me.
            int val1 = (int)StackManipulation.Pop();
            StackManipulation.Push(val1 == 0 ? 1 : 0);
        }
    }
}
