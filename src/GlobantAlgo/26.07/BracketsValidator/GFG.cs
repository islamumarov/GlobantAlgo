
using System;
using System.Collections.Generic;
using System.Text;

public class GFG
{

    public void reverse(char[] A, int l, int h)
    {
        if (l < h)
        {
            char ch = A[l];
            A[l] = A[h];
            A[h] = ch;
            reverse(A, l + 1, h - 1);
        }
    }
    
    public string reverseParentheses(string str, int len)
    {
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < len; i++)
        {
            if (str[i] == '(')
            {
                st.Push(i);
            }
            
            else if (str[i] == ')')
            {
                char[] A = str.ToCharArray();
                reverse(A, st.Peek() + 1, i);
                str = new string(A);
                st.Pop();
            }
        }
        
        string res = "";
        for (int i = 0; i < len; i++)
        {
            if (str[i] != ')' && str[i] != '(')
            {
                res += str[i];
            }
        }
        return res;
    }
}
