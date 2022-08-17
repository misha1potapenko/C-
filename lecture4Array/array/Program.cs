// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// string [,] table = new string [2,5];

// table [1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {   
//     for(int columns =0; columns < 5; columns++)
//     {
//          Console.WriteLine($"-{table[rows, columns]}");
//     }

// }

int[,] matrix = new int[3, 4];
<<<<<<< HEAD:lecture4Array/Program.cs
for (int i = 0; i < 3; i++)
{   
    for(int j =0; j < 4; j++)
=======
for (int i = 0; i < matrix.GetLength(0); i++)
{   
    for(int j =0; j < matrix.GetLength(1); j++)
>>>>>>> 7822c48487129e05b22b52938f9fba827c2e9188:lecture4Array/array/Program.cs
    {
         Console.Write($"-{matrix[i, j]}");
    }
    Console.WriteLine();
}