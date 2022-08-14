// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [str, column];

void FillArray(int [,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i,j] = new Random().Next(1, 10);
                    }
            }
    }
void PrintArray(int [,] array)
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
FillArray(array);
PrintArray(array);

void AvarageColumn(int[,] array)
    {   
        
        for(int j = 0; j < array.GetLength(0); j++)
            {
                double sumColumn = 0;
                for(int i = 0; i < array.GetLength(1); i++)
                    {
                        sumColumn = sumColumn + array[i,j];
                    }
                Console.WriteLine(sumColumn/column);
            }
    }
AvarageColumn(array);