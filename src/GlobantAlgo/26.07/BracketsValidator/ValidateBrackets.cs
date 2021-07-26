using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsValidator
{
    public class ValidateBrackets
    {
        public readonly char[] Brackets = { '(', ')', '[', ']', '{', '}' };
        public readonly char[] OpenBrackets = { '(', '[', '{' };
        public readonly char[] CloseBrackets = { ')', ']', '}' };
        public bool IsValidBrackets(string bracketsLine)
        {
            if (bracketsLine == null || bracketsLine.Length == 0)
                return false;
            if (bracketsLine.Length == 1)
                return false;

            var brackets = bracketsLine.ToCharArray();
            var openBrackets = OpenBrackets;
            var closeBrackets = CloseBrackets;
            var stack = new Stack<char>();
            for (int i = 0; i < brackets.Length; i++)
            {
                if (openBrackets.Contains(brackets[i]))
                    stack.Push(brackets[i]);
                if (closeBrackets.Contains(brackets[i]))
                {
                    if (stack.Count == 0)
                        return false;
                    if (Array.IndexOf(openBrackets, stack.Pop()) != Array.IndexOf(closeBrackets, brackets[i]))
                        return false;
                }
            }
            return stack.Count == 0;
        }

        public bool IsBracketsValid(string bracketsLine)
        {
            if (bracketsLine == null || bracketsLine.Length == 0)
                return false;
            if (bracketsLine.Length == 1)
                return false;
            var brackets = bracketsLine.ToCharArray();
            var openBrackets = OpenBrackets;
            var closeBrackets = CloseBrackets;
            var stack = new Stack<char>();
            for (int i = 0; i < brackets.Length; i++)
            {
                if (openBrackets.Contains(brackets[i]))
                    stack.Push(brackets[i]);
                if (closeBrackets.Contains(brackets[i]))
                {
                    if (stack.Count == 0)
                        return false;
                    if (stack.Pop() != brackets[i])
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
