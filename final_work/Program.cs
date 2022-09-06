// Написать программу, которая из имеющегося массива сток
// формирует массив из строк, длина которых меньше либо равна 3 символа.


string[] firstArray = {"name", "one", "23", "dad", "finally", "great"};

string[] secondArray = new string[firstArray.Length];

for (int i = 0; i < firstArray.Length; i++)
    {  
        if (Convert.ToInt32(firstArray[i].Length) < 4) secondArray[i] = firstArray[i]; 
    }

void PrintArray(string[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }

PrintArray(secondArray);

