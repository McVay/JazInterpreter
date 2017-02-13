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
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 <= val1 ? 1 : 0);
        }
        public static void GreaterOrEqual()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 >= val1 ? 1 : 0);
        }
        public static void Less()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 < val1 ? 1 : 0);
        }
        public static void Greater()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 > val1 ? 1 : 0);
        }
    }
}
