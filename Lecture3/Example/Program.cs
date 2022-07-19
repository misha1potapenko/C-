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
    while(j < count1)
    {
        result = result + text;
        j++;
    }
    return result;
}
string res = Metod4(5, "Love ");
Console.WriteLine(res);