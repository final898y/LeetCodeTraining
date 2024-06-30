// See https://aka.ms/new-console-template for more information
using _70_Climbing_Stairs;
//Console.WriteLine(False.ClimbStairs(35));

//ANS=3
ClimbStairs(3);


//You are climbing a staircase. Each time you can either climb 1 or 2 steps.
//When you take one step, the value of n will be reduced to n-1 and similarly if you take 2 steps it will reduce to n-2.
//Thus finding the number of ways becomes same as the finding the nth fibonacci number.
//@areetrahalder
int ClimbStairs(int n)
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
