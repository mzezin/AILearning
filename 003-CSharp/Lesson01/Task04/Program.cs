// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Поочередно введите 3 числа:");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
int max = numberA > numberB ? numberA : numberB;
max = max > numberC ? max : numberC;
Console.WriteLine($"Большее число: {max}");