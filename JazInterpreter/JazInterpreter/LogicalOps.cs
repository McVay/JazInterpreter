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
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 & val1);
        }
        public static void Or()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 | val1);

        }
        public static void Not()
        {
            // Not sure that is correct but works for me.
            var val1 = StackManipulation.Pop();
            StackManipulation.Push(val1 == 0 ? 1 : 0);
        }
    }
}
