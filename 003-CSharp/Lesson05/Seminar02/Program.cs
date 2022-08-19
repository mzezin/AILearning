// Задача 2: Задайте массив из 10 элементов и положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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

int[] switchNegAndPos(int[] array)
{
    int[] result = (int [])array.Clone();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0 - result[i];
    }
    return result;
}

int[] array = generateArray();
int[] result = switchNegAndPos(array);
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Случайный массив c замененными элементами: ");
Console.WriteLine(prettyPrintArray(switchNegAndPos(array)));
Console.Write("Случайный массив c замененными элементами (через LINQ): ");
int[] resultLINQ = array.Select(x => 0 - x).ToArray();
Console.WriteLine(prettyPrintArray(resultLINQ));
