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

void FindMaxMin(int[]array)

    {   
        int max = array[0];
        int min = array[0];
        int maxIndex = 0;
        int minIndex = 0;
        int MaxMin = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                    }
                else if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i; 
                    }
            }
        MaxMin = max - min;
        Console.WriteLine($"min = {min}, max = {max}, minIndex = {minIndex}, maxIndex = {maxIndex} Разница = {MaxMin}");
    }
void PrintArray(int[] newCol)
    {
        for (int i = 0; i < newCol.Length; i++)
            {
                Console.Write($"{newCol[i]}, ");
            }
        Console.WriteLine();
    }
FillArray(array);
PrintArray(array);
FindMaxMin(array);

