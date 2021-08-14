using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictWinnerName
{
    public static class PairGameWinner
    {
        public static bool PredictTheWinner(int[] nums)
        {
            return winner(nums, 0, nums.Length - 1, 1) >= 0;
        }
        public static int winner(int[] nums, int s, int e, int turn)
        {
            if (s == e)
                return turn * nums[s];
            int a = turn * nums[s] + winner(nums, s + 1, e, -turn);
            int b = turn * nums[e] + winner(nums, s, e - 1, -turn);
            return turn * Math.Max(turn * a, turn * b);
        }
    }
}