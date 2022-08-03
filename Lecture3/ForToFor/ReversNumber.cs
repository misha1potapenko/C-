
int inter = Convert.ToInt32(Console.ReadLine());
int  a = 0, reverse = 0;
for (int i = inter; i > 0; i = (i / 10))
{
  a = i % 10;
  reverse = (reverse * 10) + a;
 Console.Write($"{reverse} ");

}
if (reverse == inter) 
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}