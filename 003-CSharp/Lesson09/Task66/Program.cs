// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Через рекурсию
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumNumbers(int start, int end, int currentSum)
{
    currentSum += start;
    if (start == end)
        return currentSum;
    return sumNumbers(++start, end, currentSum);
}

Console.WriteLine(sumNumbers(1, 15, 0));
Console.WriteLine(sumNumbers(4, 8, 0));
