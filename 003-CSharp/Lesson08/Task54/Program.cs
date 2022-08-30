// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] generate2dArray(int height = 2, int width = 2, int min = 1, int max = 11)
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

int[,] sortInRows(int[,] array)
{
    int[,] result = (int[,])array.Clone();
    int tempElement;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < result.GetLength(1); k++)
            {
                if (result[i, j] < result[i, k])
                {
                    tempElement = result[i, j];
                    result[i, j] = result[i, k];
                    result[i, k] = tempElement;
                }
            }
        }
    }

    return result;
}

int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] randomArray = generate2dArray(3, 5);

Console.WriteLine("Тестовые данные: ");
Console.WriteLine(prettyPrint2dArray(testArray));

Console.WriteLine("Строки отсортированы: ");
Console.WriteLine(prettyPrint2dArray(sortInRows(testArray)));

Console.WriteLine("==============================");

Console.WriteLine("Случайные данные: ");
Console.WriteLine(prettyPrint2dArray(randomArray));

Console.WriteLine("Строки отсортированы: ");
Console.WriteLine(prettyPrint2dArray(sortInRows(randomArray)));
