// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Factorial(int n)
{
    if (n == 1) return 1;
    else return n* Factorial(n-1);
}
Console.WriteLine(Factorial(4));