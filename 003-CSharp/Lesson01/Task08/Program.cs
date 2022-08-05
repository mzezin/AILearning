// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int iterator = 2;
List<int> result =  new List<int>();
while (iterator <= number)
{
  result.Add(iterator);
  iterator += 2;
}
Console.WriteLine(string.Join(", ", result));
