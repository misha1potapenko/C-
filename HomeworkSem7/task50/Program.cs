// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента либо значение элемента в двумерном массиве,
//   и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует
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

Console.Write("Введите одо или два числа через запятую: ");
string number = Console.ReadLine()!;
int [] ForNumber = number.Split(',').Select(int.Parse).ToArray();
int count = ForNumber.Length;
void FindElement(int[] ForNumber)
    {
        if (count == 1)
            {
                int ifNoElements1 = 0;
                for(int i = 0; i < array.GetLength(0); i++)
                    {
                        for(int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i,j] == ForNumber[0])
                                    {
                                        Console.WriteLine($"Такой элемент есть, его индекс {i},{j}");         
                                    }
                                else ifNoElements1 ++;                        
                            }  
                    }
                if (ifNoElements1 == column*str ) Console.WriteLine("Такого элемента нет");               
            }
        else if (count == 2)
            {
                int ifNoElements = 0;
                for(int i = 0; i < array.GetLength(0); i++)
                    {
                        for(int j = 0; j < array.GetLength(1); j++)
                            {
                                if (ForNumber[0] == i && ForNumber[1] == j)
                                    {
                                        Console.WriteLine($"Такой элемент есть, он равен {array[i,j]}");         
                                    } 
                                else ifNoElements ++;                     
                            }
                            
                    }
                if (ifNoElements == column*str ) Console.WriteLine("Такого элемента нет");       
            }
    }
FindElement(ForNumber);
