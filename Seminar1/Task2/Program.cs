// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.WriteLine("Введите целое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
  Console.Write("Некоректный ввод!"); 
  return; 
}
int count = -num;

while (count <= num)
{
    Console.Write($"{count} ");
    count++; //count = count + 1// count += 1
}

