// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N:");
int number = int.Parse(Console.ReadLine());
int iterator = 1;
List<int> result = new List<int>();
while (iterator <= number)
{
    result.Add( Convert.ToInt32( Math.Pow(iterator, 3)));
    iterator++;
}
Console.WriteLine(string.Join(", ", result));
