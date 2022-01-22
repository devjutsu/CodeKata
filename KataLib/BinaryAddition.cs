using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace KataLib
{
    public class BinaryAddition
    {
        // public static string AddBinary(int a, int b)
        //     => Convert.ToString(a + b, 2);

        public static string AddBinary(int a, int b)
        {
            string result = "";
            var A = a.ToString();
            var B = b.ToString();
            int s = 0;

            int i = A.Length - 1, j = B.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {
                s += ((i >= 0) ? A[i] - '0' : 0);
                s += ((j >= 0) ? B[j] - '0' : 0);
                result = (char)(s % 2 + '0') + result;

                s /= 2;
                i--; j--;
            }
            return result;
        }
    }
}
