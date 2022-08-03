//  Напишите программу,
//   которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
string chetvert (int a )
{
    if (a == 1) return "Для первой четверти x > 0; y > 0";
    else if (a == 2) return "Для второй четверти x < 0; y > 0";
    else if (a == 3) return "Для третьей четверти x < 0; y < 0";
    else if  (a == 4) return "Для четвёртой четверти x > 0; y < 0";
    else
    {
        return "not found";

    }
    
        

}

Console.WriteLine(chetvert(a));


