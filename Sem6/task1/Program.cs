// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// void PrintArray(int[] newCol)
// {
//     int count = newCol.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(newCol[position]);
//         position++;
//     }
// }
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         Console.Write(collection[index]);
//         Console.Write(", ");
//         index++;
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int min = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array [min]) min = j;
//         }

//         int temporary = array[i];
//         array[i] = array[min];
//         array[min] = temporary;
//     }
// }


// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



void PrintArray(int[] newCol)
{
    int count = newCol.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(newCol[position] + ", ");
        position++;
    }
}

Console.WriteLine("Enter the massive size");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];


for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(-9,10);


    }


PrintArray(massive);
Console.WriteLine();
int count = size/2;
int bath = 0;
for (int i = 0; i < count; i++ )
{
    bath = massive[i];
    massive[i] = massive[size-1 - i];
    massive[size-1-i] = bath;
}
PrintArray(massive);
