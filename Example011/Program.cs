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
int c2 = 12;
int a3 = 555;
int b3 = 65;
int c3 = 74;


int max = Max(Max(a1, a2, a3), Max(c1, c2, c3), Max(b1, b2, b3) );
Console.WriteLine(max);