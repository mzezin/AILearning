// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 81 2 9

// 8 4 2 4

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

int[,] processArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

void printSolution(int[,] array, bool isTestData = false)
{
    string dataType = isTestData ? "Тестовые" : "Случайные";
    Console.WriteLine($"{dataType} данные: ");
    Console.WriteLine(prettyPrint2dArray(array));
    Console.WriteLine("Обработанные данные: ");
    Console.WriteLine(prettyPrint2dArray(processArray(array)));
}

int[,] randomArray = generate2dArray();
int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

printSolution(testArray, true);
printSolution(randomArray, false);
