﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTraining
{
    public class AcceptedBefore202410
    {
        //You are climbing a staircase. Each time you can either climb 1 or 2 steps.
        //When you take one step, the value of n will be reduced to n-1 and similarly if you take 2 steps it will reduce to n-2.
        //Thus finding the number of ways becomes same as the finding the nth fibonacci number.
        //@areetrahalder
        //70.Climbing Stairs
        //https://leetcode.com/problems/climbing-stairs/description/

        static public int ClimbStairs(int n)
        {
            if (n <= 1) return 1;
            int firstNum = 1, secondNum = 1, thirdNum = 0;
            for (int i = 2; i < n + 1; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
            }
            return thirdNum;
        }

        //2037. Minimum Number of Moves to Seat Everyone
        //https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/description/
        static public int minMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            int sum = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                sum += Math.Abs(seats[i] - students[i]);
            }
            return sum;
        }

        //2133. Check if Every Row and Column Contains All Numbers
        //https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
        static public bool CheckValid(int[][] matrix)
        {

            List<int[]> result = new List<int[]>();


            for (int i = 0; i < matrix.Length; i++)
            {
                int[] row_array = new int[matrix.Length];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    row_array[j] += matrix[i][j];
                }
                result.Add(row_array);
            }
            for (int j = 0; j < matrix.Length; j++)
            {
                int[] col_array = new int[matrix.Length];
                for (int i = 0; i < matrix[j].Length; i++)
                {
                    col_array[i] += matrix[i][j];
                }
                result.Add(col_array);
            }
            foreach (int[] i in result)
            {
                if (checksame(i))
                {
                    continue;
                }
                return false;
            }
            return true;
            static bool checksame(int[] array)
            {
                for (int x = 0; x < array.Length; x++)
                {
                    Array.Sort(array);
                    if (array[x] == x + 1)
                    {
                        continue;
                    }
                    return (false);
                }
                return (true);
            }
        }
        //**3110. score of a string**
        //https://leetcode.com/problems/score-of-a-string/description/
        static public int ScoreOfString(string s)
        {
            byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(s);
            int sum = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                sum += Math.Abs(asciiBytes[i] - asciiBytes[i + 1]);
            }
            return sum;
        }

        //## **2769. Find the Maximum Achievable Number**
        //https://leetcode.com/problems/find-the-maximum-achievable-number/description/
        static public int TheMaximumAchievableX(int num, int t)
        {
            int x = num + t * 2;
            return x;
        }

        //## **1929. Concatenation of Array**
        //https://leetcode.com/problems/concatenation-of-array/description/
        static public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length * 2; i++)
            {
                if (i < nums.Length)
                {
                    ans[i] = nums[i];
                }
                else
                {
                    ans[i] = nums[i - nums.Length];
                }
            }
            return ans;
        }

        //## **1920. Build Array from Permutation**
        //https://leetcode.com/problems/build-array-from-permutation/description/
        static public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }

            return (ans);

        }

        //## **1646. Get Maximum in Generated Array**
        //https://leetcode.com/problems/get-maximum-in-generated-array/description/
        static public int GetMaximumGenerated(int n)
        {
            int[] nums = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                if (i < 2)
                {
                    nums[i] = i;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        nums[i] = nums[i / 2];
                    }
                    else
                    {
                        nums[i] = nums[(i - 1) / 2] + nums[(i - 1) / 2 + 1];
                    }
                }
            }

            return (nums.Max());

        }

        //## **1. Two Sum**
        //2024 / 06 / 04
        //https://leetcode.com/problems/two-sum/description/
        static public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            int j = 1;
            int x = 0;
            while (i < nums.Length - 1)
            {

                while (j < nums.Length - i)
                {
                    x = nums[i] + nums[i + j];
                    if (x != target)
                    {

                        j++;
                        continue;

                    }
                    else
                    {
                        break;
                    }
                }
                if (x == target)
                {
                    break;
                }
                else
                {
                    i++;
                    j = 1;
                }

            }
            return ([i, j + i]);
        }
    }
}
