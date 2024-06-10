// See https://aka.ms/new-console-template for more information

int[][] matrix =
        [
            [1, 2, 3],
            [3, 1, 2],
            [2, 3, 1],
            [2, 2, 2, 2],
            [2, 3, 1],
        ];

int[] sum_fixed_i = new int[matrix.Length];

int[] sum_fixed_j = new int[matrix.Length];
int checksum = 0;
for (int i = 1; i <= matrix.Length; i++)
{
    checksum += i;
}

List<int[]> rowset = new List<int[]>();

for (int i = 0; i < matrix.Length; i++)
{
    Console.WriteLine($"i={i}");

    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.WriteLine($"j={j}");
        sum_fixed_i[j] += matrix[i][j];
        sum_fixed_j[i] += matrix[i][j];
    }
}

foreach (int i in sum_fixed_i)
{
    Console.WriteLine(i);
}

foreach (int j in sum_fixed_j)
{
    Console.WriteLine(j);
}