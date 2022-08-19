// Задача 3: Задайте массив из 8 случайных чисел.
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



int[] generateArray(int length = 8, int min = -100, int max = 101)
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

bool myFind(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return true;
    }
    return false;
}

int[] array = generateArray();
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Введите число: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (myFind(array, number))
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}
else
    Console.WriteLine("Неправильный ввод");
