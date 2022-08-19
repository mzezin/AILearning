// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] generateArray(int length, int min=-100, int max=101)
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
    return ($"[{String.Join(", ",array)}]");
}

int countEvenElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
    }
    return result;
}
;

Console.Write("Введите длину случайного массива:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
  Console.Write("Неправильный ввод");
} else
{
int[] array = generateArray(length, 100, 1000);
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Количество чётных чисел в массиве: ");
Console.WriteLine(countEvenElements(array));
}