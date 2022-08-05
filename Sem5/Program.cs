// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[20];
int sumN = 0;
int sumP = 0;

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(-9,10);

        if(massive[i] == number) 
            {
                Console.WriteLine("Да");
            }

       else Console.WriteLine("Нет");;


    }



void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }

PrintArray(massive);
Console.WriteLine();

