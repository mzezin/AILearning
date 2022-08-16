// Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// string s = Console.ReadLine();
// if (int.TryParse(s , out int result)) {
// Console.WriteLine("число");
// Console.WriteLine(result);

// } else {
// Console.WriteLine("не число");
// }


int[] pairProduct(int[] array)
{
    int halfLength = array.Length / 2;
    List<int> result = new List<int>();
    for (int i = 0; i < halfLength; i++)
    {
        result.Add(array[i] * array[array.Length - i - 1]);
    }

    if (array.Length % 2 != 0)
        result.Add(array[halfLength]);
    return result.ToArray();
}
;
int[] input = { 1, 2, 3, 4, 5 };

// int[] input = { 6, 7, 3, 6 };
Console.WriteLine(String.Join(", ", pairProduct(input)));
