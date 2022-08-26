// Задача 50. Напишите программу, которая на вход принимает число,
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

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

int[]? findIn2dArray(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                return new int[] { i, j };
        }
    }
    return null;
}

void generateOutput(int[,] array, int x)
{
    int[]? result = findIn2dArray(array, x);
    Console.WriteLine("Массив: ");
    Console.WriteLine(prettyPrint2dArray(array));
    if (result != null)
        Console.WriteLine($"Число {x} найдено по координатам [{result[0]}; {result[1]}]");
    else
        Console.WriteLine($"Число {x} не найдено в массиве");
}

Console.WriteLine("Тестовые данные: ");
generateOutput(new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }, 17);
Console.WriteLine("");
Console.WriteLine("Случайные данные: ");
generateOutput(generate2dArray(), new Random().Next(-10, 11));




// Console.WriteLine("Случайный массив: ");
// Console.WriteLine(prettyPrint2dArray(randomArray));
