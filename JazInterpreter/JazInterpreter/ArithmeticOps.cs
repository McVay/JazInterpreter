using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    public static class ArithmeticOps
    {
        public static void Add()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 + val1);
        }
        public static void Subtract()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 - val1);
        }
        public static void Multiply()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 * val1);
        }
        public static void Divide()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 / val1);
        }
        public static void Modulo()
        {
            var val1 = StackManipulation.Pop();
            var val2 = StackManipulation.Pop();
            StackManipulation.Push(val2 % val1);
        }
    }
}
