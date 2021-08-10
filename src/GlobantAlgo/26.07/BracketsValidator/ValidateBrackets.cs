using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsValidator
{
    public class ValidateBrackets
    {
        public readonly char[] OpenBrackets = { '(', '[', '{' };
        public readonly char[] CloseBrackets = { ')', ']', '}' };
        public bool IsValidBrackets(string bracketsLine)
        {
            if (bracketsLine == null || bracketsLine.Length == 0)
                return false;
            if (bracketsLine.Length == 1)
                return false;

            var brackets = bracketsLine.ToCharArray();
            var stack = new Stack<char>();
            for (int i = 0; i < brackets.Length; i++)
            {
                if (OpenBrackets.Contains(brackets[i]))
                    stack.Push(brackets[i]);
                if (CloseBrackets.Contains(brackets[i]))
                {
                    if (stack.Count == 0)
                        return false;
                    if (Array.IndexOf(OpenBrackets, stack.Pop()) != Array.IndexOf(CloseBrackets, brackets[i]))
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
