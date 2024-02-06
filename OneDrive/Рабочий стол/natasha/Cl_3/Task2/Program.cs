// void PrintSquares(int limit)
// {
//     int i = 1;
//     while (i <= limit)
//     {
//         Console.Write($"{i * i} ");
//         i++;
//     }
// }
// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);

void FillArray(int[] arr)
{
    foreach (int e in arr)
    {
        Random rnd = new Random();
       e = rnd.Next(1, 10);
    }
}
void PrintArray(int[] arr)
{
 foreach (int e in arr)    {
        Console.Write($"{e} ");
    }
}

int GetSumOfElements(int[] arr)
{
   int sum = 0;
    foreach (int e in arr)
    {
sum = sum + e;       
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    foreach (int e in arr)
    {
    product = product * e;
    }
    Console.Write(product);
    return product;
}
Console.WriteLine($"{GetProductOfElements(product)} ");

// double CalculateFormula(int a, int b, int c, int d);
// {
//     double numenator = a * b;
//    int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }
//  double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);


int n = 5;
int [] arr = new int [n];
// int GetSumOfElements(arr);
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"{GetSumOfElements(sum)} ");
Console.WriteLine($"{GetProductOfElements(product)} ");
// Console.WriteLine(sum);
// Console.WriteLine(product);

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//    int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }
//  double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);