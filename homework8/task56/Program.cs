﻿// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить 
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов 
// в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, column];

void FillArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i,j] = new Random().Next(1, 20);
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
FillArray(array);
PrintArray(array);
Console.WriteLine();

void SelectionSort(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1)-1; j++)
                    {
                        int min = j;

                        for (int k = j + 1 ; k < array.GetLength(1); k++)
                            {
                                
                                if (array[i,k] < array[i,min]) 
                                    {
                                        min = k;
                                    }
                                    

                            }
                        //  Console.WriteLine($"{min}, ");
                        int temp = array[i,j];
                        array[i,j] = array[i,min];
                        array[i,min] = temp;
                    }


            }
    }

SelectionSort(array);
PrintArray(array);