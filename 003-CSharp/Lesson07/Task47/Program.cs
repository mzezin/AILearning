// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] generate2dArray(int height = 4, int width = 3, int min = -10, int max = 11)
{
    double[,] result = new double[height, width];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min + 1, max - 1) + rnd.NextDouble();
        }
    }
    return result;
}

string prettyPrint2dArray(double[,] array)
{
    string result = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += Math.Round(array[i, j], 2) + " ";
        }
        result += "\n";
    }
    return result;
}

Console.WriteLine("Введите высоту массива: ");
string m = Console.ReadLine();
Console.WriteLine("Введите длину массива: ");
string n = Console.ReadLine();

if (int.TryParse(m, out int height) && int.TryParse(n, out int width))
    Console.WriteLine(prettyPrint2dArray(generate2dArray(height, width)));
else
    Console.WriteLine("Неправильный ввод");
