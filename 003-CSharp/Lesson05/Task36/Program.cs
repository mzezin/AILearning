// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumOddPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
            result+=array[i];
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
int[] array = generateArray(length);
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(sumOddPositions(array));
}
