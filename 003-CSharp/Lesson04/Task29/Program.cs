// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
}
string result = String.Join(',', array);

Console.WriteLine($"[{result}]");

Math.Pow(1, 2);
