using System;
using ThreeLinesOfString;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var actual = MergeLines.IsInterleave("aabcc", "dbbca", "aadbbcbcac"); // ?
            var actualR = MergeLines.IsInterleave("dbbca", "aabcc", "aadbbcbcac"); // true
            var actual1 = MergeLines.IsInterleave("aabcc", "dbbca", "aadbbbaccc"); //false

            var watch = System.Diagnostics.Stopwatch.StartNew();
            var actual2 = MergeLines.IsInterleave("abababababababababababababababababababababababababababababababababababababababababababababababababbb",
                "babababababababababababababababababababababababababababababababababababababababababababababababaaaba",
                "abababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababbb");

            var act =  MergeLines.IsInterleave("abbab", "ba", "ababbab");

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(actual1);
            Console.WriteLine(actual);
            Console.WriteLine(actual2 + " Time: " + elapsedMs);
        }
    }
}
