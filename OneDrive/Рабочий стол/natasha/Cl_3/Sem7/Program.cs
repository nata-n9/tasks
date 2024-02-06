// Задача 1
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbersMN(int start, int end)
{
    if (end>start)
    {
        PrintNumbersMN(start, end-1);
    }
    Console.WriteLine(end);
}
if(m < n)

{
    PrintNumbersMN(m,n); 
    }
else
{
    PrintNumbersMN(n,m); }


// задача 2

Console.WriteLine("Введите M: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int l = Convert.ToInt32(Console.ReadLine());

int akkerman(int k, int l)
{
if (k == 0) 
{
    return (l + 1);
    }
else if (l == 0) 
{
    return akkerman(k-1, 1);
    }
else return akkerman(k-1, akkerman(k, l-1));
}

Console.WriteLine(akkerman(k, l));

// задача 3

 void PrintArray(int[] array, int i = 0)
{
    if(i != array.Length) 
    {
        PrintArray(array, i + 1);
        Console.Write($"{array[i]} ");
    }
}
        
    int[] array = new int[] {9, 99, 34, 8, 45, 22};
    PrintArray(array);            