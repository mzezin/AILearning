// See https://aka.ms/new-console-template for more information
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] generate2dArray(int height = 5, int width = 7,
 int min = -10, int max = 11)
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

string prettyPrintArray(double[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

double[] rowAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[j, i];
        }
        result[i] = Math.Round(result[i] / array.GetLength(0), 2);
    }
    return result;
}

int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] randomArray = generate2dArray();

Console.WriteLine("Тестовые данные: ");
Console.WriteLine(prettyPrint2dArray(testArray));
Console.WriteLine("Среднее арифметическое столбцов: ");
Console.WriteLine(prettyPrintArray(rowAverage(testArray)));


Console.WriteLine("Случайные данные: ");
Console.WriteLine(prettyPrint2dArray(randomArray));
Console.WriteLine("Среднее арифметическое столбцов: ");
Console.WriteLine(prettyPrintArray(rowAverage(randomArray)));