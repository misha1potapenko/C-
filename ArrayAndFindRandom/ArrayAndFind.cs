void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 100);

        index++;
    }
}

void PrintArray(int[] newCol)
{
    int count = newCol.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(newCol[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        
    }
    return position;
}


int[] massif = new int[100];
FillArray(massif);
PrintArray(massif);
Console.WriteLine();


int pos = IndexOff(massif, 28);
Console.WriteLine(pos);