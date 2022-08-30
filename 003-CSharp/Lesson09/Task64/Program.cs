// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Через рекурсию

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void countNumbers(int start, int end)
{
    Console.Write(start);
    if (start != end)
        Console.Write(", ");
    else
        return;
    countNumbers(++start, end);
}

countNumbers(1, 5);
Console.WriteLine();
countNumbers(4, 8);
