// See https://aka.ms/new-console-template for more information

//**3110. score of a string**
//https://leetcode.com/problems/score-of-a-string/description/
static int ScoreOfString(string s)
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
static int TheMaximumAchievableX(int num, int t)
{
    int x = num + t * 2;
    return x;
}

//## **1929. Concatenation of Array**
//https://leetcode.com/problems/concatenation-of-array/description/
static int[] GetConcatenation(int[] nums)
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
static int[] BuildArray(int[] nums)
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
static int GetMaximumGenerated(int n)
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
static int[] TwoSum(int[] nums, int target)
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