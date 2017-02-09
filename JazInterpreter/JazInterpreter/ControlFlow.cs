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
    }
}
