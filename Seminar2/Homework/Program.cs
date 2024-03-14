//Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число для проверки: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (CheckDivisibility(number))
        {
            Console.WriteLine($"{number} кратно одновременно 7 и 23.");
        }
        else
        {
            Console.WriteLine($"{number} не кратно одновременно 7 и 23.");
        }
    }

    static bool CheckDivisibility(int num)
    {
        if (num % 7 == 0 && num % 23 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
