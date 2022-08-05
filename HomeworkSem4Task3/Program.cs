// Напишите программу, которая создает массив
// из введенных через запятую цифр
// и выводит этот массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите несколько цифр через запятую: ");
string ForArray = Console.ReadLine()!;
int length = ForArray.Length;
Console.WriteLine(length);

int [] Array = ForArray.Split(',').Select(int.Parse).ToArray();


void PrintArray(int[] newCol)
{
    int count = newCol.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(newCol[position]);
        position++;
    }
}

PrintArray(Array);