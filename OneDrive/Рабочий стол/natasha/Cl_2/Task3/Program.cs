int n = 10;
int[] arr = { 1, 4, 2, 6, 5, 9, 7, 8, 23, 64 };
int i = 0;
while (i < n)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}