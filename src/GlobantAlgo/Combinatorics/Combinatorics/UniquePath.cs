using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
    public class UniquePath
    {

        public static int UniquePaths(int m, int n)
        {
            if (n == 1 && m == 1)
                return 1;
            if(m < n)
                return (int)Combination(m+n-2, m-1);
            return (int)Combination(m + n - 2, n - 1);
        }
        public static long  Combination(int n, int m)
        {
            long a =1, b =1;
            while(m > 0)
            {
                a *= n--;
                b *= m--;
            }
            return a / b;
        }

    }
}
