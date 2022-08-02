// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int [] array = {1, 4, 5, 6, 10, 34, 33, 12, 14};
int FunctionAvg (int [] array)
{
    int length = array.Length;
    int sum = 0;
    for (int i = 0; i < length; i++ )
    {
        sum = sum + array[i];
         
    }
    int Avg = sum/length;
    return Avg;
}


int SumAvg = FunctionAvg(array);
Console.WriteLine(SumAvg);

int SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int min = i;
        for (int j = i +1; j < array.Length; j++)
        {
            
        }

    }
}