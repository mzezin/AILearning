// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число:");
string input = Console.ReadLine();
try
{
    int number = int.Parse(input);
    if (number < 100 || number > 999)
        throw (new Exception());
    Console.WriteLine(number.ToString()[1]);
}
catch (Exception)
{
    Console.WriteLine($"Строка {input} не является трехзначным числом");
}
