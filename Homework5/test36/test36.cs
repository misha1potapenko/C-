// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
void PrintArray(int[] newCol)
    {
        for (int i = 0; i < newCol.Length; i++)
            {
                Console.Write($"{newCol[i]}, ");
            }
        Console.WriteLine();
    }
void FindPositive(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i+=2)
            {
                sum = sum + array[i];
                
            }
        Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах: {sum}");
    }
FillArray(array);
PrintArray(array);
FindPositive(array);