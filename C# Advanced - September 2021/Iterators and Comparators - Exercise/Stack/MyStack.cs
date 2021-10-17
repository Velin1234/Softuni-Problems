using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> stack;
        public MyStack(params T[] stackInput)
        {
            stack = new List<T>(stackInput);
        }

        public void Push(params T[] elements)
        {
            foreach (var curElement in elements)
            {
                stack.Insert(stack.Count, curElement);
            }
        }
        public T Pop()
        {
            if (stack.Any(element => stack.Count == 0))
            {
                throw new ArgumentException("No elements");
            }
            T element = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return element;

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
