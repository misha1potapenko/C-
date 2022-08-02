// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] array = { 1, 4, 5, 6, 10, 34, 33, 12, 14, 65, 32, 45, 32, 15, 16 };
int FunctionAvg(int[] array)
{
    int length = array.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + array[i];

    }
    int Avg = sum / length;
    return Avg;
}


int SumAvg = FunctionAvg(array);
Console.WriteLine(SumAvg);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min]) min = j;

        }

        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SelectionSort(array);
PrintArray(array);

void Median(int[] array)

{
    double med = 0;
    int length = array.Length;
    double half = length % 2;

    if ((length % 2) != 0) med = array[length % 2];
    else med = 1;
    Console.WriteLine($"{med}");
}
Median(array);