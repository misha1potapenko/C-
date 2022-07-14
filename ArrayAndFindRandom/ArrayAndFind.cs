void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        Console.Write(collection[index]);
        Console.Write(", ");
        index++;
    }
    Console.WriteLine();
//     int count = 0;
//     int max = collection[count];
//     int min = collection[count];
//     while (length < count)
//     {
//        if(collection[count] > max) max = collection[count]; 
       
//        if(collection[count] < min) min = collection[count]; 
//        count +=1;


//     }
// Console.WriteLine(max);
// Console.WriteLine(min);

    
   
 
    int count = 0;
    int max = collection[count];
    int min = collection[count];
    while (length > count)
    {
       if(collection[count] > max) max = collection[count]; 
       
       if(collection[count] < min) min = collection[count]; 
       count++;
      


  
    }

    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Минимальное число: {min}");
}



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

// int IndexOff(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while(index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
        
//     }
//     return position;
// }


int[] massif = new int[10];
FillArray(massif);
// PrintArray(massif);
// Console.WriteLine();


// int pos = IndexOff(massif, 5);
// Console.WriteLine(pos);