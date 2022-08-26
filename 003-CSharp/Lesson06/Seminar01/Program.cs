// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.).
// Элементы одномрного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] generateArray(int length = 8, int min = -10, int max = 11)
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

int[] myReverse(int[] array)
{
    int[] result = (int[])array.Clone();
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[array.Length - i - 1];
        result[array.Length - i - 1] = array[i];
    }
    return result;
}

int[] testArray1 = new int[] { 1, 2, 3, 4, 5 };
int[] testArray2 = new int[] { 6, 7, 3, 6 };
int[] randomArray = generateArray();

Console.Write("Тестовый массив 1: ");
Console.WriteLine(prettyPrintArray(testArray1));
Console.Write("Перевернутый массив: ");
Console.WriteLine(prettyPrintArray(myReverse(testArray1)));

Console.Write("Тестовый массив 2: ");
Console.WriteLine(prettyPrintArray(testArray2));
Console.Write("Перевернутый массив: ");
Console.WriteLine(prettyPrintArray(myReverse(testArray2)));

Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(randomArray));
Console.Write("Перевернутый массив: ");
Console.WriteLine(prettyPrintArray(myReverse(randomArray)));
