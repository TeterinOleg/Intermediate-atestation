//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой координатной четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй координатной четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвёртой координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка находится на одной из координатных осей.");
        }
    }
}
