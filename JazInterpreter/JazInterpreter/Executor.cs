using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    public class Executor
    {
        public static void Execute(KeyValuePair<string, string> instruction)
        {
            switch (instruction.Key)
            {
                #region StackManipulation
                case "push":
                    StackManipulation.Push(int.Parse(instruction.Value));
                    break;
                case "rvalue":
                    StackManipulation.RValue(instruction.Value);
                    break;
                case "lvalue":
                    StackManipulation.LValue(instruction.Value);
                    break;
                case "pop":
                    StackManipulation.Pop();
                    break;
                case ":=":
                    StackManipulation.Set();
                    break;
                case "copy":
                    StackManipulation.Copy();
                    break;
                #endregion
                #region ControlFlow
                case "goto":
                    ControlFlow.Goto(instruction.Value);
                    break;
                case "gofalse":
                    ControlFlow.GoFalse(instruction.Value);
                    break;
                case "gotrue":
                    ControlFlow.GoTrue(instruction.Value);
                    break;
                case "halt":
                    ControlFlow.Halt();
                    break;
                #endregion
                #region ArithmeticOps
                case "+":
                    ArithmeticOps.Add();
                    break;
                case "-":
                    ArithmeticOps.Subtract();
                    break;
                case "*":
                    ArithmeticOps.Multiply();
                    break;
                case "/":
                    ArithmeticOps.Divide();
                    break;
                case "div":
                    ArithmeticOps.Modulo();
                    break;
                #endregion
                #region LogicalOps
                case "&":
                    LogicalOps.And();
                    break;
                case "|":
                    LogicalOps.Or();
                    break;
                case "!":
                    LogicalOps.Not();
                    break;
                #endregion
                #region RelationalOps
                case "<>":
                    RelationalOps.NotEqual();
                    break;
                case "=":
                    RelationalOps.Equal();
                    break;
                case ">=":
                    RelationalOps.GreaterOrEqual();
                    break;
                case "<=":
                    RelationalOps.LessOrEqual();
                    break;
                case ">":
                    RelationalOps.Greater();
                    break;
                case "<":
                    RelationalOps.Less();
                    break;
                #endregion
                #region Output
                case "print":
                    Output.Print();
                    break;
                case "show":
                    Output.Show(instruction.Value);
                    break;
                #endregion
                #region Subprogram Control
                case "begin":
                    SubprogramControl.Begin();
                    break;
                case "end":
                    SubprogramControl.End();
                    break;
                case "return":
                    SubprogramControl.Return();
                    break;
                case "call":
                    SubprogramControl.Call(instruction.Value);
                    break;
                #endregion
            }
        }
    }
}
