int[] array = {1,2,3,4,5,13,7,8,9,11,12,13,15,16,17,17,18,44};

int n = array.Length;
//Console.WriteLine(n);

int find = 13;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index +=1;
}
