Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine()!;
Console.WriteLine("Привет, ");
Console.WriteLine(username);

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
for (int i = 0; i < 3; i++)
{   
    for(int j =0; j < 4; j++)
    {
         Console.Write($"-{matrix[i, j]}");
    }
    Console.WriteLine();
}