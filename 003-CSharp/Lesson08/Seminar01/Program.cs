// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int[,] generate2dArray(int height = 5, int width = 4, int min = 0, int max = 11)
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

int[,] switchFirstAndLastRow(int[,] array)
{
    int[,] result = (int[,])array.Clone();
    int tempValue;
    for (int i = 0; i < result.GetLength(1); i++)
    {
        tempValue = result[0, i];
        result[0, i] = result[result.GetLength(0)-1, i];
        result[result.GetLength(0)-1, i] = tempValue;
    }
    return result;
}

int[,] randomArray = generate2dArray();

Console.WriteLine(prettyPrint2dArray(randomArray));


Console.WriteLine(prettyPrint2dArray(switchFirstAndLastRow(randomArray)));
