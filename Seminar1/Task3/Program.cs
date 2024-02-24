// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трёхзначное целое число");
int num = Convert.ToInt32(Console.ReadLine());
int numChek = num;

if (num < 0) numChek = -num;
if (numChek >= 100 && numChek <= 999)
{
    int sumDigits = numChek / 100 + numChek % 10;
    Console.WriteLine($"{num} => {sumDigits}");
}
else
{
    Console.WriteLine("Некоректный ввод!");
}