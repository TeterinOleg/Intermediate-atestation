//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;
class Program
{
static void Main()
{
Console.Write("Введите координаты точки X и Y через пробел:");string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
Console.WriteLine("1");
else if (x < 0 && y > 0)
Console.WriteLine("2");
else if (x < 0 && y < 0)
Console.WriteLine("3");
else if (x > 0 && y < 0)
Console.WriteLine("4");
else
Console.WriteLine("Точка находится на оси координат");
}
}
