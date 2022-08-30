// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] generate2dArray(int height = 2, int width = 2, int min = 1, int max = 10)
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

int minRowSum(int[,] array)
{
    int[,] result = (int[,])array.Clone();
    int minSum = 0;
    int minIndex = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (i == 0)
            minSum = rowSum;
        if (rowSum < minSum)
        {
            minIndex = i;
            minSum = rowSum;
        }
    }
    return minIndex;
}

int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] randomArray = generate2dArray(3, 5);

Console.WriteLine("Тестовые данные: ");
Console.WriteLine(prettyPrint2dArray(testArray));

Console.Write("Номер строки с минимальной суммой: ");
Console.WriteLine(minRowSum(testArray) + 1);

Console.WriteLine("==============================");

Console.WriteLine("Тестовые данные: ");
Console.WriteLine(prettyPrint2dArray(randomArray));

Console.Write("Номер строки с минимальной суммой: ");
Console.WriteLine(minRowSum(randomArray) + 1);
