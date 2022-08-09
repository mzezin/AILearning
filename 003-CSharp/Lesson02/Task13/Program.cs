// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
string input = Console.ReadLine();
try
{
  int number = int.Parse(input);
  Console.WriteLine(number.ToString()[2]);
}
catch (FormatException)
{
   Console.WriteLine($"Строка {input} не является числом");
}
catch (IndexOutOfRangeException)
{
   Console.WriteLine($"У числа {input} нет третьей цифры");
}

 