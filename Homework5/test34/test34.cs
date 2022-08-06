// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введете количесво элементов в массиве: ");
int NumbersOfElements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[NumbersOfElements];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(111, 999);
    }
}
FillArray(array);
void PrintArray(int[] newCol)
    {
        for (int i = 0; i < newCol.Length; i++)
            {
                Console.Write($"{newCol[i]}, ");
            }
        Console.WriteLine();
    }
PrintArray(array);
void FindPositive(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            
            }
        Console.WriteLine($"Количество четных элементов: {count}");
    }
FindPositive(array);
