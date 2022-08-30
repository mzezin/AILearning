// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool numberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return true;
    }
    return false;
}

int[] generateXUniqueTwoDigitsNumbers(int x)
{
    if (x > 90)
        throw new Exception("Невозможно сгенерировать более 90 уникальных двузначных чисел");
    int[] result = new int[x];
    for (int i = 0; i < x; i++)
    {
        int randomNumber = new Random().Next(10, 100);
        if (numberInArray(result, randomNumber))
            i--;
        else
            result[i] = randomNumber;
    }
    return result;
}

int[,,] generate3dArray(int x = 2, int y = 2, int z = 2)
{
    int elementsCount = x * y * z;
    if (elementsCount > 90)
        throw new Exception(
            "Невозможно заполнить массив такого размера уникальными двузначными числами"
        );
    int[,,] result = new int[x, y, z];
    int[] values = generateXUniqueTwoDigitsNumbers(elementsCount);
    int counter = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = values[counter];
                counter++;
            }
        }
    }
    return result;
}

string printElement(int value, int x, int y, int z)
{
    return $"{value}({x},{y},{z}) ";
}

void print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(printElement(array[j, k, i], j, k, i)); //вопрос по порядку индексов, но сделал как в примере
            }
            Console.WriteLine();
        }
    }
}

int[,,] randomArray = generate3dArray();
print3dArray(randomArray);
