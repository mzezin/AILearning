// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] generateRealNumberArray(int length, int min = -100, int max = 100)
{
    double[] result = new double[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble() * new Random().Next(min, max);
    }
    return result;
}

string prettyPrintArray(double[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

double findMinMaxDelta(double[] array)
{
    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxIndex])
            maxIndex = i;
        if (array[i] < array[minIndex])
            minIndex = i;
    }
    return array[maxIndex] - array[minIndex];
}
;

Console.Write("Введите длину случайного массива:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
    Console.Write("Неправильный ввод");
}
else
{
    double[] array = generateRealNumberArray(length, 0, 100);
    Console.Write("Случайный массив: ");
    Console.WriteLine(prettyPrintArray(array));
    Console.Write("Разница между максимальным и минимальным элементами массива: ");
    Console.WriteLine(findMinMaxDelta(array));
    // Console.WriteLine(findMinMaxDelta(new double[]{3, 7, 22, 2, 78}));

}
