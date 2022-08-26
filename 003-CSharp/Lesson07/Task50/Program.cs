// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] generate2dArray(int height = 4, int width = 3, int min = -10, int max = 11)
{
    int[,] result = new int[height, width];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

string prettyPrint2dArray(int[,] array)
{
    string result = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + " ";
        }
        result += "\n";
    }
    return result;
}

int? numberAtCoords(int[,] array, int x, int y)
{
    if (x >= array.GetLength(0) || y >= array.GetLength(1) || x < 0 || y < 0)
        return null;
    return array[x, y];
}

void generateOutput(int[,] array, int x, int y)
{
    int? result = numberAtCoords(array, x, y);
    Console.WriteLine("Массив: ");
    Console.WriteLine(prettyPrint2dArray(array));
    Console.WriteLine($"Координаты: {x}, {y} ");
    if (result != null)
        Console.WriteLine($"Число найдено и равно: {result}");
    else
        Console.WriteLine("Число не найдено");
}

Console.WriteLine("Тестовые данные: ");
generateOutput(new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }, 1, 7);
Console.WriteLine("");
Console.WriteLine("Случайные данные: ");
generateOutput(generate2dArray(), new Random().Next(0, 4), new Random().Next(0, 5));




// Console.WriteLine("Случайный массив: ");
// Console.WriteLine(prettyPrint2dArray(randomArray));
