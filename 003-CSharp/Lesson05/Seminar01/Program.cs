// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] generateArray(int length = 10, int min = -9, int max = 10)
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

int[] sumNegativeAndPositive(int[] array)
{
    int[] result = new int[2] { 0, 0 };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            result[0] += array[i];
        else if (array[i] > 0)
            result[1] += array[i];
    }
    return result;
}

int[] array = generateArray();
int[] result = sumNegativeAndPositive(array);
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Cумма отрицательных элементов массивf: ");
Console.WriteLine(result[0]);
Console.Write("Cумма положительных элементов массивf: ");
Console.WriteLine(result[1]);
