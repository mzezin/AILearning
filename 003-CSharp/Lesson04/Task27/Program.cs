// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int digitsSum(int number)
{
    return number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum();
}
;

string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine(digitsSum(number));
}
else
{
    Console.WriteLine("Введите целое число");
}
;
