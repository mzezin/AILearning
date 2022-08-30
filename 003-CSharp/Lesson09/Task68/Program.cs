// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int ackermann(int m, int n)
{
    if (m < 0 || n < 0)
        throw new Exception("Неправильный ввод");
    if (m == 0)
        return n + 1;
    if ((m != 0) && (n == 0))
        return ackermann(m - 1, 1);
    return ackermann(m - 1, ackermann(m, n - 1));
}

Console.WriteLine(ackermann(2, 3)); // не совпадает с примером
Console.WriteLine(ackermann(3, 2)); // возможно перепутаны местами аргументы в примере и надо читать как A(n,m) = 29
