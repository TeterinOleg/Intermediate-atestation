int M = 4; // Задаем начальное значение промежутка
int N = 34; // Задаем конечное значение промежутка

PrintNaturalNumbersInRange(M, N);

// Рекурсивный метод для вывода всех натуральных чисел в промежутке от M до N
static void PrintNaturalNumbersInRange(int M, int N)
{
    if (M <= N)
    {
        Console.Write(M + " "); // Выводим текущее число
        PrintNaturalNumbersInRange(M + 1, N); // Рекурсивный вызов для следующего числа
    }
}
