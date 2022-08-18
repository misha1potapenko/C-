// Задача 56: Задайте прямоугольный двумерный массив.
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
FillArray(array);
PrintArray(array);
void PrintArray1(int[] newCol)
    {
        int count = newCol.Length;
        int position = 0;
        while (position < count)
            {
                 Console.Write($"{newCol[position]}; ");
                 position++;
            }
    }

void FindMin(int[] array)
    {
         int min = 0;
        for (int i = 0; i < array.Length; i++)
            { 
               
                if (array[i] < array[min]) min = i;
                
            }
        
        Console.WriteLine($"Строкой с минимальной суммой элементов является {min} строка");
    }

void FindMinStr(int[,] array)
    {
        int[] ForArray = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
            {
                int sumStr = 0;           
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        sumStr = sumStr + array[i,j];

                    }
                ForArray[i] = sumStr;
            }
        PrintArray1(ForArray);
        Console.WriteLine();
        FindMin(ForArray);


        
    }

FindMinStr(array);
