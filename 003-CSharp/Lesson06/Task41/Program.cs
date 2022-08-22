// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int countPositives(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}

string prettyPrintArray(int[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

Console.WriteLine("Введите количество чисел:");
if (!int.TryParse(Console.ReadLine(), out int m))
    throw new Exception("Неправильный ввод");
int[] array = new int[m];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число № {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int input))
    {
        array[i] = input;
    }
    else
    {
        Console.WriteLine("Неправильный ввод, введите число повторно");
        i--;
    }
}

Console.WriteLine($"Исходный массив: {prettyPrintArray(array)}");
Console.WriteLine($"Количество чисел больше нуля: {countPositives(array)}");
