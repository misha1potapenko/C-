int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;

}
int a1 = 3;
int b1 = 6;
int c1 = 1111;
int a2 = 78;
int b2 = 25;
int c2 = 123545;
int a3 = 555;
int b3 = 65;
int c3 = 74;

int[] array = {11, 12, 44, 55, 565, 89, 75, 212, 458};
array[0] = 256;
Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]) );

Console.WriteLine(max);
