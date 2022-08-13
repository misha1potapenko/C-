// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3

Console.Write("Введите несколько цифр через запятую: ");
string ForArray = Console.ReadLine()!;


int [] Array = ForArray.Split(',').Select(int.Parse).ToArray();

void PrintArray(int[] newCol)
{
    int count = newCol.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{newCol[position]}, ");
        position++;
    }
}

PrintArray(Array);
Console.WriteLine();

void ShowPositive(int[] Array)
    {
    
        int count = 0;
        for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0) count++;
            }   
            Console.WriteLine($"Положительных чисел: {count}");
    }
ShowPositive(Array);