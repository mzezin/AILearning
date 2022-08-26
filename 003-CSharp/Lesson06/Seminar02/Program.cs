// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве.
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33

int[] generateArray(int length = 10, int min = -10, int max = 11)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

string prettyPrintArray(int[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

double averageOfPositives(int[] array)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
            sum += array[i];
        }
    }
    return (double)sum / count;
}

double averageOfPositivesLINQ(int[] array)
{
    return array.Where(x => (x > 0)).Average();
}

int[] testArray = new int[5] { 1, -5, 8, 4, -9 };
int[] array = generateArray();

Console.Write("Тестовый массив: ");
Console.WriteLine(prettyPrintArray(testArray));
Console.Write("Среднее положительных элементов массива: ");
Console.WriteLine(averageOfPositives(testArray));

Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Среднее положительных элементов массива: ");
Console.WriteLine(averageOfPositives(array));
