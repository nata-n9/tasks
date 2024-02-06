// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//    int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }
//  double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);

int [] CreateArray(int size, int minRange, int maxRange)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (100, 1000);
    }
         return array;
}

int GetCountOfEven(int [] arr)
{
    int count = 0;
    foreach (int number in arr)
    {
        if (number %2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(N, 100, 999);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Total: [ {GetCountOfEven(array)} ]");