using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    public static class RelationalOps
    {
        public static void NotEqual()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 != val1 ? 1 : 0);
        }
        public static void Equal()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 == val1 ? 1 : 0);
        }
        public static void LessOrEqual()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 <= val1 ? 1 : 0);
        }
        public static void GreaterOrEqual()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 >= val1 ? 1 : 0);
        }
        public static void Less()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 < val1 ? 1 : 0);
        }
        public static void Greater()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 > val1 ? 1 : 0);
        }
    }
}
