// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов в массиве: ");
int ForArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[ForArray];

void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-40, 41);
            }
    }