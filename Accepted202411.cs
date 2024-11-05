using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetcodeTraining
{
    public class Accepted202411
    {
        //412. Fizz Buzz
        //https://leetcode.com/problems/fizz-buzz/submissions/1443845687/
        //2024/11/05
        static public IList<string> FizzBuzz(int n)
        {
            string[] results = new string[n + 1];
            results[0] = "0";
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "FizzBuzz";
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    results[i] = "Fizz";
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    results[i] = "Buzz";
                }
                else
                {
                    results[i] = i.ToString();
                }
            }
            string[] newArray = results.Skip(1).ToArray();
            return newArray;
        }
    }
}
