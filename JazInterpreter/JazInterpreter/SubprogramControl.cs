using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazInterpreter
{
    public static class SubprogramControl
    {
        private static Stack<int> beginIndexStack = new Stack<int>();
        private static Stack<int> callIndexStack = new Stack<int>(); //store locations of where subroutines where called from, to return to later
        public static List<string> toRemove = new List<string>(); //store keys in memory table that were create by subroutine calls
        private static List<string> localVariables = new List<string>();
        public static bool inSubprogram = false;

        public static void Begin()
        {
            if (Program.MemoryTableCopy.Count > Program.MemoryTable.Count) //update memory table if needed
            {
                Program.MemoryTable = new Dictionary<string, int>(Program.MemoryTableCopy);
            }

            inSubprogram = true;
            beginIndexStack.Push(toRemove.Count); //where the current region of local variables started
        }

        public static void End()
        {
            if (beginIndexStack.Count > 0)
            {
                int beginIndex = beginIndexStack.Pop();
                int endIndex = getEndIndex(beginIndex);

                for (int i = 0; i < toRemove.Count; i++)
                {
                    if (i >= beginIndex && i < endIndex)
                    {
                        if (!localVariables.Contains(toRemove[i]))
                        {
                            localVariables.Add(toRemove[i]);
                        }
                    }
                }
            }
           

            foreach (string s in localVariables) //delete local variables from memory table
            {
                int value;
                if (Program.MemoryTableCopy.TryGetValue(s, out value))
                {
                    Program.MemoryTable.Remove(s);
                }
            }

            if (beginIndexStack.Count == 0)
            {
                inSubprogram = false;
            }
        }

        public static void Return()
        {
            foreach(KeyValuePair<string,int> pair in Program.MemoryTableCopy) //update memory table
            {
                if(!Program.MemoryTable.ContainsKey(pair.Key)) 
                {
                    Program.MemoryTable.Add(pair.Key, pair.Value);
                }
                
            }

            Program.LineCount = callIndexStack.Pop();
        }

        public static void Call(string key)
        {
            int lineNumber;
            int beginIndex = (int)beginIndexStack.Peek();
            int endIndex = getEndIndex(beginIndex);
            
            Program.MemoryTableCopy = new Dictionary<string, int>(Program.MemoryTable); 
            Program.MemoryTable.Clear();

            for (int i = 0; i < toRemove.Count; i++)
            {
                if(i >= beginIndex && i < endIndex)
                {
                    localVariables.Add(toRemove[i]);
                }
            }

            foreach (string s in localVariables) //repopulate memory table with only local variables, only used for current proc call
            {
                int value;
                if (Program.MemoryTableCopy.TryGetValue(s, out value))
                {
                    Program.MemoryTable.Add(s, value);
                }
            }

            
            if (Program.LabelTable.TryGetValue(key, out lineNumber)) 
            {
                callIndexStack.Push(Program.LineCount);
                Program.LineCount = lineNumber;
            }

            inSubprogram = false;
        }

        private static int getEndIndex(int beginIndex) //get end of region of local variables stored in toRemove list
        {
            if (beginIndexStack.Count > 1) //end location is before the next begin  
            {
                //get value out of stack
                int topElement = (int)beginIndexStack.Pop();
                int nextElement = (int)beginIndexStack.Pop();

                //restore stack 
                beginIndexStack.Push(nextElement);
                beginIndexStack.Push(topElement);

                return nextElement;
            }
            else
            {
                return toRemove.Count;
            }
            
        }
    }
}
