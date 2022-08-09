// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
string input = Console.ReadLine();
try
{
    int number = int.Parse(input);
    if (number < 1 || number > 7)
        throw (new Exception());
    Console.WriteLine(number == 6 || number == 7 ? "да" : "нет");
}
catch (Exception)
{
    Console.WriteLine($"Строка {input} не является номером дня недели");
}
