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