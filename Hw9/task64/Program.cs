// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8"
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

string Numbers(int M, int N)

    {

        if (M <= N) return $"{M}, " + Numbers(M+1, N);
        else return string.Empty;
    }
// void FillArray(int[,] array)
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//             {
//                 for(int j = 0; j < array.GetLength(1); j++)
//                     {
//                         array[i,j] = new Random().Next(1, 20);
//                     }
//             }
//     }
// void PrintArray(int[,] array)
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//             {
//                 for(int j = 0; j < array.GetLength(1); j++)
//                     {
//                         Console.Write($"{array[i,j]} ");
//                     }
//                 Console.WriteLine();
//             }
//     }
Console.WriteLine(Numbers(M,N));
