using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stack<string> AddRange(IEnumerable<string> collection)
        {
            foreach (var str in collection)
            {
                this.Push(str);
            }
            return this;

        }
    }
}
