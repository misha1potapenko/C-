// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ForNumber = 0;
int sumNumber = 0;

int SumForNumber(int number)
    {
        for (int i = 10; i < 1000000000; i = i * 10)
        {
            ForNumber = number  % 10;
            sumNumber = sumNumber + ForNumber;
            number = number / 10;
            
        }
        return sumNumber;
    }

Console.WriteLine($"Сумма цифр составляет: {SumForNumber(number)}");