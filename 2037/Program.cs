// See https://aka.ms/new-console-template for more information
//2037. Minimum Number of Moves to Seat Everyone
//https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/description/?envType=daily-question&envId=2024-06-13



int[] seats = [3, 1, 5];
int[] students = [2, 7, 4];
Console.WriteLine(MinMovesToSeat(seats, students));
static int MinMovesToSeat(int[] seats, int[] students)
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

