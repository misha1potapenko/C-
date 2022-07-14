void TestArray (int[] test)
{
    int length = test.Length;
    int count = 0;
    while (count < length)
    {
        test[count] = new Random().Next(1, 10);
        Console.Write(test[count]);
        Console.Write (", ");
        count++;


    }



}

int[] forTest = new int[10];
TestArray(forTest);
