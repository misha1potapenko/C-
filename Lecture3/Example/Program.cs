// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

void Metod1(string met, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(met);
        i++;
    }

}

Metod1(count: 1, met: "New");

int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);

string Metod4(int count1, string text)
{
    int j = 0;
    string result = String.Empty;
    while (j < count1)
    {
        result = result + text;
        j++;
    }
    return result;
}
string res = Metod4(5, "Love ");
Console.WriteLine(res);



// for(int i = 2; i <= 10; i+=1)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();

// }

string text = "Так говорила в июле 1805"
+ "года известная Анна Павловна Шерер, фрейлина и "
+ "приближенная императрицы Марии Феодоровны, встречая"
+ " важного и чиновного князя Василия, первого"
+ " приехавшего на ее вечер. Анна Павловна кашляла "
+ " несколько дней, у нее был грипп, как она говорила";

// string s = "qwerty"
//             012
// s[3] r 

string Replays(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }
    return result;
}
string newText = Replays(text, ' ', '-');
Console.WriteLine(newText);

int[] array = { 1, 2, 3, 4, 7, 11, 33, 12, 1, 12, 14, 12, 16, 33, 22, 11, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 PrintArray(array);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array [min]) min = j;
        }

        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
}

SelectionSort(array);
PrintArray(array);




