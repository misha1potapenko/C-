// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Напишите число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > b)
{
    Console.WriteLine("Больше число a");
}
else 
{
    Console.WriteLine("Больше число b");
}