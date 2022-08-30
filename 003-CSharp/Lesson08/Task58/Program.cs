// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[] extractRow(int[,] array, int rowNumber)
{
    int[] result = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result[i] = array[rowNumber, i];
    }
    return result;
}

int[] extractColumn(int[,] array, int colNumber)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result[i] = array[i, colNumber];
    }
    return result;
}

int scalarProduct(int[] vectorA, int[] vectorB)
{
    int result = 0;
    int vectorLength = vectorA.Length;
    if (vectorLength != vectorB.Length)
        throw new Exception("Векторы разной длины");
    for (int i = 0; i < vectorLength; i++)
    {
        result += vectorA[i] * vectorB[i];
    }
    return result;
}

int[,] matrixProduct(int[,] matrixA, int[,] matrixB)
{
    if (!(matrixA.GetLength(1) == matrixB.GetLength(0)))
        throw new Exception("Матрицы не совместимы");
    int width = matrixA.GetLength(0);
    int height = matrixB.GetLength(1);
    int[,] result = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            int[] row = extractRow(matrixA, i);
            int[] column = extractColumn(matrixB, j);
            result[i, j] = scalarProduct(row, column);
        }
    }
    return result;
}

int[,] testMatrixA = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] testMatrixB = new int[,] { { 3, 4 }, { 3, 3 } };

int[,] randomMatrixA = generate2dArray(3, 5);
int[,] randomMatrixB = generate2dArray(5, 3);

Console.WriteLine("Тестовые данные: ");
Console.WriteLine("Матрица A: ");
Console.WriteLine(prettyPrint2dArray(testMatrixA));
Console.WriteLine("Матрица B: ");
Console.WriteLine(prettyPrint2dArray(testMatrixB));
Console.WriteLine("Произведение матриц A * B: ");
Console.WriteLine(prettyPrint2dArray(matrixProduct(testMatrixA, testMatrixB)));

Console.WriteLine("==============================");

Console.WriteLine("Случайные данные: ");
Console.WriteLine("Матрица A: ");
Console.WriteLine(prettyPrint2dArray(randomMatrixA));
Console.WriteLine("Матрица B: ");
Console.WriteLine(prettyPrint2dArray(randomMatrixB));
Console.WriteLine("Произведение матриц A * B: ");
Console.WriteLine(prettyPrint2dArray(matrixProduct(randomMatrixA, randomMatrixB)));
