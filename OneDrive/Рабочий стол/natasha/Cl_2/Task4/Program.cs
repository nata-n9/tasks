int n = 5;
int[] arr = { 2, 7, 1, 23, 11 };
// int i = 0;
// int max = arr[0];
// while (i < arr.Length)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     i = i + 1;
// }
//         Console.WriteLine(max);

int max = arr[0];
for (int j = 0; j < n; j++)
    while (j < n)
    {
        if (arr[j] > max)
        {
            max = arr[j];
        }
    }
Console.WriteLine(max);

