// See https://aka.ms/new-console-template for more information
//2133. Check if Every Row and Column Contains All Numbers
//https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/description/


using leetcode2133;

int[] test = { 1, 2, 3, 4,5, 6 };
//Console.WriteLine(false_ex.CheckValidtest(test));
int[][] matrix =
        [
            [1, 2, 3],
            [3, 1, 2],
            [3, 3, 1],
        ];
//Console.WriteLine(matrix.Length);
//Console.WriteLine(matrix[2][1]);
//Console.WriteLine(false_ex.CheckValidsum(matrix));
Console.WriteLine(CheckValid(matrix));

//成功
static bool CheckValid(int[][] matrix)
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
        if(checksame(i))
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
            if (array[x] == x+1)
            {
                continue;
            }
            return (false);
        }
        return (true);
    }
}


