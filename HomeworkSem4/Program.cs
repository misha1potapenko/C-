// Задача 25: Напишите цикл, который принимает на вход два числа
//  (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

int DegreeNumber(int NumberA)

    {
        int DigreeA = 1;
        for (int i = 1; i <= NumberB; i++)
        {
            
            DigreeA = DigreeA * NumberA;
            // Console.WriteLine(NumberA);
        }
        return DigreeA;
    }

Console.WriteLine(DegreeNumber(NumberA));