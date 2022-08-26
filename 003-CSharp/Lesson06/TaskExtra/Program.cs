// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10.
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

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

int sumOfDiagonal(int[,] array)
{
    int sum = 0;
    int limiter =
        (array.GetLength(0) < array.GetLength(1)) ? array.GetLength(0) : array.GetLength(1);
    for (int i = 0; i < limiter; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] randomArray = generate2dArray();

Console.WriteLine("Тестовый массив: ");
Console.WriteLine(prettyPrint2dArray(testArray));
Console.WriteLine($"Сумма чисел на главной диагонали: {sumOfDiagonal(testArray)}");

Console.WriteLine("Случайный массив: ");
Console.WriteLine(prettyPrint2dArray(randomArray));
Console.WriteLine($"Сумма чисел на главной диагонали: {sumOfDiagonal(randomArray)}");
