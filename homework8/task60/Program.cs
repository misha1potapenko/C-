// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int str = 4;
int column = 4;
int[,] array = new int[str, column];
void FillArray(int[,] array)
    {
        int count = 10;           
        for(int j = 0; j < array.GetLength(1); j++)
            {
                array[0,j] = count++;        
            }
        for(int i = 1; i <= 2; i++)
            { 
                array[i,3] = count++; 
            }
        for(int j = 3; j >= 0; j--)
            {
                array[3,j] = count++;         
            }
        for(int i = 2; i >= 1; i--)
            { 
                array[i,0] = count++; 
            }  
        for(int j = 1; j <=2; j++)
            { 
                array[1,j] = count++; 
            }
        for(int j = 2; j >=1; j--)
            { 
                array[2,j] = count++; 
            }     
    }
void PrintArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i,j]} ");
                    }
                Console.WriteLine();
            }
    }
FillArray(array);
PrintArray(array);