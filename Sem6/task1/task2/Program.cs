// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Решение в группах задач:
// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Write("Введите стороны треугольника: ");
int first = Convert.ToInt32(Console.ReadLine());
int second= Convert.ToInt32(Console.ReadLine());
int third = Convert.ToInt32(Console.ReadLine());
if (first < (second + third) &&  second < (first+ third) && third < (first+second)) Console.WriteLine("Yes");
else Console.WriteLine("No");