//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Число должно быть натуральным.");
            return;
        }

        Console.Write($"Цифры числа {n} через запятую: ");
        PrintDigits(n);
    }

    static void PrintDigits(int number)
    {
        if (number < 10)
        {
            Console.WriteLine(number);
        }
        else
        {
            PrintDigits(number / 10);
            Console.WriteLine(", " + number % 10);
        }
    }
}
