// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


string ReverseString(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

bool isPalindrome(string s)
{
    return s == ReverseString(s);
}

Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine();
try
{
    int number = int.Parse(input);
    if (number < 10000 || number > 99999)
        throw (new Exception());
    Console.WriteLine(isPalindrome(input) ? "да" : "нет");
}
catch (Exception)
{
    Console.WriteLine($"Строка {input} не является пятизначным числом");
}
