// Задача 4: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12*

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] generateArray(int length = 12, int min = -100, int max = 101)
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

int findInRange(int[] array, int min = 10, int max = 99)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
            result++;
    }
    return result;
}

int[] array = generateArray();
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));

Console.Write("Случайный массив c замененными элементами: ");
Console.WriteLine((findInRange(array)));
