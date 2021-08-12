using System;
using System.Collections.Generic;

namespace ThreeLinesOfString
{
    public class MergeLines
    {

        public static bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            bool[,] d = new bool[s1.Length + 1, s2.Length + 1];
            d[0, 0] = true;

            for (int i = 0; i < s1.Length; i++)
            {
                if (d[i, 0] && s1[i] == s3[i])
                {
                    d[i + 1, 0] = true;
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (d[0, i] && s2[i] == s3[i])
                {
                    d[0, i + 1] = true;
                }
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s3[i + j - 1] && s2[j - 1] == s3[i + j - 1])
                    {
                        d[i, j] = d[i - 1, j] || d[i, j - 1];
                    }

                    else if (s1[i - 1] == s3[i + j - 1])
                    {
                        d[i, j] = d[i - 1, j];
                    }

                    else if (s2[j - 1] == s3[i + j - 1])
                    {
                        d[i, j] = d[i, j - 1];
                    }
                }
            }

            return d[s1.Length, s2.Length];

        }

 /*
        /// <summary>
        /// Check can we build third line from first two lines
        /// </summary>
        /// <param name="firstLine">First line</param>
        /// <param name="secondLine">Second line</param>
        /// <param name="thirdLine">Third line</param>
        /// <returns>True if we can build third line from first two lines</returns>
        public static bool CanBuildThirdLine(string firstLine, string secondLine, string thirdLine)
        {

            if (firstLine.Length + secondLine.Length < thirdLine.Length) return false;

            List<char> firstLineList = new List<char>();
            Stack<char> first = new Stack<char>();
            var firtLineChar = firstLine.ToCharArray();
            Array.Reverse(firtLineChar);
            firstLineList.AddRange(firtLineChar);
            firstLineList.ForEach(c => first.Push(c));

            List<char> secondLineList = new List<char>();
            Stack<char> second = new Stack<char>();
            var secondLineChar = secondLine.ToCharArray();
            Array.Reverse(secondLineChar);
            secondLineList.AddRange(secondLineChar);
            secondLineList.ForEach(c => second.Push(c));


            List<char> thirdLineList = new List<char>();
            Stack<char> third = new Stack<char>();
            var thirdLineChar = thirdLine.ToCharArray();
            Array.Reverse(thirdLineChar);
            thirdLineList.AddRange(thirdLineChar);
            thirdLineList.ForEach(c => third.Push(c));


            bool result = RecurciveCheck(first, second, third);

            return result;
        }

        public static bool RecurciveCheck(Stack<char> first, Stack<char> second, Stack<char> third)
        {
            if (first.Count == 0 && second.Count == 0 && third.Count == 0) return true;
            if (first.Count != 0 && first.Peek() == third.Peek())
            {
                first.Pop();
                third.Pop();
                return RecurciveCheck(first, second, third);
            }
            if (second.Count != 0 && second.Peek() == third.Peek())
            {
                second.Pop();
                third.Pop();
                return RecurciveCheck(second, first, third);
            }
            else
                return false;
        } 
 */
    }

}