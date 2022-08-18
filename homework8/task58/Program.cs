// Задача 58: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
Console.Write("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[str, column];
int[,] array2 = new int[str, column];
void FillArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i,j] = new Random().Next(1, 10);
                    }
            }
    }
void PrintArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i,j]} ");
                    }
                Console.WriteLine();
            }
    }
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
void Multiplication(int[,] array1, int[,] array2 )
    {
        int[,] array3 = new int[str, column];
        for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                    {
                        array3[i,j] = array1[i,j] * array2[i,j];
                    }
            }
        PrintArray(array3);
    }
Multiplication(array1, array2);

