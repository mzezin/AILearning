// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
// string numberString = number.ToString();
// string result = numberString[0].ToString() + numberString[2].ToString();
string numberString = number.ToString();
string result = numberString[0].ToString() + numberString[2].ToString();

Console.WriteLine(number);
Console.WriteLine(result);
// еще вариант
// Console.WriteLine($"{numberString[0]}{numberString[2]}");


// Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.WriteLine("Поочередно введите 2 числа:");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

int modulus = numberA % numberB;
if (modulus == 0)
{
    Console.WriteLine($"Число {numberB} кратно {numberA}");
}
else
{
    Console.WriteLine($"Числа {numberA} и {numberB} некратны друг другу, остаток от деления = {modulus}");
}

// Задача 3. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

Console.WriteLine("Введите число:");
int numberX = int.Parse(Console.ReadLine());

if ( numberX % 7 == 0 && numberX % 23 == 0)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}

// еще вариант
// string message = ( numberX % 7 == 0 && numberX % 23 == 0) ? "да" : "нет";
// Console.WriteLine(message);
