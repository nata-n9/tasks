// void ZeroEvenElemens(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }

// void PrintArray(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] array = { 1, 2, 3, 4, 5 };
// ZeroEvenElemens(array);
// PrintArray(array);


// Random rnd = new Random();
// int size = 1000;
// int[] arr_int = new int[size];
// int i=0;
// while(i < size)
// {
//     arr_int[i] = rnd.Next(1, 10);
//     i++; 
// }

// i = 0;
// while(i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i++;
// }


// int size = 3;
// int[] arr_int = new int[size];
// int i = 0;
// while (i < size)
// {
//     Console.WriteLine("Введите элемент массива (целое число):");
//     string input = Console.ReadLine();
//     arr_int[i] = Convert.ToInt32(input);
//     i++;
// }
// i = 0;
// while (i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i++;
// }

// Console.WriteLine("Введите элемент массива (целое число):");
//     string input = Console.ReadLine();
//     arr_int[i] = Convert.ToInt32(input);
//     i++;

// i = 0;
// while (i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i++;
// }
// Console.Write(text);


while (true)
{
    Console.Write("Введите целое число: ");
   string text = Console.ReadLine();

    if (text == "q")
   {
    break;
   }
   int number;
   if (int.TryParse(text, out number))
   {
    int sum = 0;
    while (number > 0)
    {
       sum += number%10;
        number /=10;

    }
    if (sum % 2==0)
    {
         break;
    }
   }
}


  
