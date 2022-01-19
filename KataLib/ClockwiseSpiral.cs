using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataTests
{
    public class TheClockwiseSpiral
    {
        public static int[,] CreateSpiral(int N)
        {
            int[,] matrix = new int[N, N];
            int numValue = 1;
            int c1 = 0, c2 = N - 1;
            while (numValue <= N * N)
            {
                //Right Direction Move  
                for (int i = c1; i <= c2; i++)
                    matrix[c1, i] = numValue++;
                //Down Direction Move  
                for (int j = c1 + 1; j <= c2; j++)
                    matrix[j, c2] = numValue++;
                //Left Direction Move  
                for (int i = c2 - 1; i >= c1; i--)
                    matrix[c2, i] = numValue++;
                //Up Direction Move  
                for (int j = c2 - 1; j >= c1 + 1; j--)
                    matrix[j, c1] = numValue++;
                c1++;
                c2--;
            }
            return matrix;
        }

        // public static int[,] CreateSpiral(int n)
        // {
        //     var arr = new int[n,n];

        //     int count = 0;
        //     int row = 0;
        //     int filler = 1;
        //     for (int i = 0; i < n / 2 + 1; i++)
        //     {
        //         for (int j = 0; j < n - row; j++)
        //         {
        //             if (arr[i, j] == 0)
        //             {
        //                 arr[i, j] = filler;
        //                 filler++;
        //             }

        //         }
        //         count++;
        //         row++;
        //         int down = i;
        //         for (int j = 0; j < n - count; j++)
        //         {
        //             if (arr[down + 1, n - row] == 0)
        //             {
        //                 arr[down + 1, n - row] = filler;
        //                 filler++;
        //                 down++;
        //             }

        //         }
        //         int left = n - row;
        //         for (int j = 0; j < n - count; j++)
        //         {
        //             if (arr[n - row, left - 1] == 0)
        //             {
        //                 arr[n - row, left - 1] = filler;
        //                 filler++;
        //                 left--;
        //             }

        //         }
        //         count++;
        //         int up = n - row;
        //         for (int j = 0; j < n - count; j++)
        //         {
        //             if (arr[up - 1, i] == 0)
        //             {
        //                 arr[up - 1, i] = filler;
        //                 filler++;
        //                 up--;
        //             }

        //         }
        //     }

        //     return arr;
        // }
    }
}
