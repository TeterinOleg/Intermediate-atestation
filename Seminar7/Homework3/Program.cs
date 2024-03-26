int[] array = { 3, 2, 8, 4, 1, 6, 9 }; // Произвольный массив
PrintArrayReverse(array, array.Length - 1);

// Рекурсивный метод для вывода элементов массива, начиная с конца
static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " "); // Выводим текущий элемент
        PrintArrayReverse(array, index - 1); // Рекурсивный вызов для предыдущего элемента
    }
}