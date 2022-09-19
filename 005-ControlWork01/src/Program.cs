string[] readArray()
{
    bool correctInput = false;
    int size = 0;
    while (!correctInput)
    {
        Console.WriteLine("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(), out size))
            correctInput = true;
        else
            Console.WriteLine("Неправильный ввод");
    }
    string[] result = new string[size];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива из {size}: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

string[] filterArray(string[] array, int maxLength = 3)
{
    int targetSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
            targetSize++;
    }
    string[] targetArray = new string[targetSize];
    int targetIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            targetArray[targetIndex] = array[i];
            targetIndex++;
        }
    }
    return targetArray;
}

void printArray(string[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

void printResult(string[] array)
{
    Console.Write("Исходные данные: ");
    printArray(array);
    Console.Write("Результат: ");
    printArray(filterArray(array));
    Console.WriteLine();
}

string[] testArray1 = new string[] { "hello", "2", "world", ":-)" };
string[] testArray2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] testArray3 = new string[] { "Russia", "Deпmark", "Kazan" };

printResult(testArray1);
printResult(testArray2);
printResult(testArray3);
printResult(readArray());


