using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2133
{
    internal class false_ex
{
        //失敗 使用sum不行
        public static bool CheckValid(int[][] matrix)
        {
            //固定列，取得個別列的sum
            int[] sum_fixed_i = new int[matrix.Length];

            int[] sum_fixed_j = new int[matrix.Length];
            int checksum = 0;
            for (int i = 1; i <= matrix.Length; i++)
            {
                checksum += i;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sum_fixed_i[j] += matrix[i][j];
                    sum_fixed_j[i] += matrix[i][j];
                }
            }
            int[] combinedArray = sum_fixed_i.Concat(sum_fixed_j).ToArray();
            foreach (int i in combinedArray)
            {
                if (i == checksum)
                {
                    continue;
                }
                return (false);
            }
            return (true);
        }



        public static bool CheckValidtest(int[] matrixtest)
        {
            for (int i = 0; i < matrixtest.Length - 1; i++)
            {
                Array.Sort(matrixtest);
                if (matrixtest[i] == i + 1)
                {
                    if (i == matrixtest.Length - 1 & matrixtest[i] == i + 1)
                    {
                        Console.WriteLine(i);
                    }
                    continue;

                }
                Console.WriteLine($"fales1_{i}");

                return (false);
            }
            return (true);

        }
    }
}
