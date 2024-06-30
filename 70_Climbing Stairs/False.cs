using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_Climbing_Stairs
{
    internal class False
    {
        //排列組合P
        public static int ClimbStairs_no(int n)
        {
            try
            {
                int half = n / 2;
                int result = 0;
                if (n % 2 == 0)
                {
                    for (int i = 0; i < n / 2 + 1; i++)
                    {
                        result += checked(Factorial(half + i) / (Factorial(half - i) * Factorial(2 * i)));
                    }
                }
                else
                {
                    for (int i = 0; i < n / 2 + 1; i++)
                    {
                        result += checked(Factorial(half + 1 + i) / (Factorial(half - i) * Factorial(2 * i + 1)));
                    }
                }
                return result;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow occurred!");
                return 0;

            }



        }

        //計算階層數(會超過最大值->失敗)
        public static int Factorial(int n)
        {
            try
            {
                int _factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    _factorial = checked(_factorial * i);
                }
                return _factorial;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Factorial Overflow occurred!");
                return 0;

            }
        }
    }
}
