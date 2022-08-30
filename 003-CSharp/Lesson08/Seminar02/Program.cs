// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.


int[,] generate2dArray(int height = 4, int width = 4, int min = 1, int max = 11)
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

int[] getMinElementIndices(int[,] array)
{
    int[] coordinates = new int[2] { 0, 0 };
    int minElement = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    }
    return coordinates;
}

int[,] removeRow(int[,] array, int rowIndex)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (i < rowIndex)
                result[i, j] = array[i, j];
            if (i > rowIndex)
                result[i, j] = array[i + 1, j];
            if (i == rowIndex)
            {
                rowIndex = -1;
                j--;
            }
            ;
        }
    }
    return result;
}

int[,] removeColumn(int[,] array, int colIndex)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1) - 1];

    for (int i = 0; i < result.GetLength(1); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            if (i < colIndex)
                result[j, i] = array[j, i];
            if (i > colIndex)
                result[j, i] = array[j, i + 1];
            if (i == colIndex)
            {
                colIndex = -1;
                j--;
            }
            ;
        }
    }
    return result;
}

int[,] removeCross(int[,] array, int[] coords)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int offsetI = 0;
    int offsetJ = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i == coords[0])
            offsetI = 1;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j == coords[1])
                offsetJ = 1;
            result[i, j] = array[i + offsetI, j + offsetJ];
        }
    }

    return result;
}

int[,] randomArray = generate2dArray();
int[] minElementCoords = getMinElementIndices(randomArray);

Console.WriteLine("Случайные данные: ");
Console.WriteLine(prettyPrint2dArray(randomArray));
Console.WriteLine("Координаты минимального элемента: ");
Console.WriteLine(String.Join(' ', minElementCoords));
Console.WriteLine("Массив с удалениями (вариант 1): ");
Console.WriteLine(
    prettyPrint2dArray(
        removeColumn(removeRow(randomArray, minElementCoords[0]), minElementCoords[1])
    )
);
Console.WriteLine("Массив с удалениями (вариант 2): ");
Console.WriteLine(prettyPrint2dArray(removeCross(randomArray, minElementCoords)));
Console.WriteLine("==============================");
