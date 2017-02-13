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
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 + val1);
        }
        public static void Subtract()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 - val1);
        }
        public static void Multiply()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 * val1);
        }
        public static void Divide()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 / val1);
        }
        public static void Modulo()
        {
            int val1 = (int)StackManipulation.Pop();
            int val2 = (int)StackManipulation.Pop();
            StackManipulation.Push(val2 % val1);
        }
    }
}
