// Задача 68: Напишите программу вычисления функции
//  Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerm(int M, int N)
{

        if (M == 0) return N + 1;
        else if (N == 0 && M > 0) return Akkerm(M - 1, 1);
        else  return Akkerm(M - 1, Akkerm(M, N - 1));
}
Console.WriteLine(Akkerm(M, N));