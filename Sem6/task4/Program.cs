// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// c клавиатуры задается размерность
//  двумерного массива, найти максимум и его индекс,
//   найти минимум и его индекс, найти среднее арифметическое
// причем надо обязательно вывести двумерный массив на экран
// Console.Write("CountSring");
// int CountString = Convert.ToInt32(Console.ReadLine());
// Console.Write("CountColumn");
// int CountColumn= Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("ведите число строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите число число стобцов");
int col = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, col];
//PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

int max = matrix[0, 0];
int maxi = 0;
int mini = 0;
int min = matrix[0, 0];
int maxj = 0;
int minj = 0;
int midl = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
            maxi = i;
            maxj = j;
        }
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            mini = i;
            minj = j;
        }
        midl = (midl + matrix[i, j]);

    }
}
midl = midl / (row * col);

Console.WriteLine("min=" + min + " index= " + mini + "," + minj);
Console.WriteLine("max=" + max + " index= " + maxi + "," + maxj);
Console.WriteLine("Среднеарифмитич.=" + midl);


