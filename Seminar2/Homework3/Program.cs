//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число от 10 до 99: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число должно быть из отрезка [10, 99].");
        }
        else
        {
            int tensDigit = number / 10;
            int unitsDigit = number % 10;

            int maxDigit = Math.Max(tensDigit, unitsDigit);

            Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}");
        }
    }
}