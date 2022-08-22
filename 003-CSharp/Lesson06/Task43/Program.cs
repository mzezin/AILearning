// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// основное решение
double[]? intersectionPoint(int b1, int k1, int b2, int k2)
{
    if (k1 == k2)
        return null;
    double x = 1.0 * (b1 - b2) / (k2 - k1);
    double y = 1.0 * (k2 * b1 - k1 * b2) / (k2 - k1);
    return new double[2] { x, y };
}

double[]? r = intersectionPoint(2, 5, 4, 9);
double[]? r = intersectionPoint(0, 1, 1, 0);
double[]? r = intersectionPoint(1, 1, 1, 1);

if (r != null)
    Console.WriteLine($"Точка пересечения прямых: ({r[0]}; {r[1]})");
else
    Console.WriteLine("Прямые не пересекаются или совпадают");

//==================================================================
// развлечения с классами

Line lineA = new Line(2, 5);
Line lineB = new Line(4, 9);
Point? p = lineA.FindIntersection(lineB);

if (p != null)
{
    Console.Write("Точка пересечения прямых: ");
    p.PrintPoint();
}
else
    Console.WriteLine("Прямые не пересекаются или совпадают");

class Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void PrintPoint()
    {
        Console.WriteLine($"({X}; {Y})");
    }
}

class Line
{
    public double K { get; }
    public double B { get; }

    public Line(double b, double k)
    {
        K = k;
        B = b;
    }

    public Point? FindIntersection(Line line)
    {
        if (K == line.K)
            return null;
        double x = 1.0 * (B - line.B) / (line.K - K);
        double y = 1.0 * (line.K * B - K * line.B) / (line.K - K);
        return new Point(x, y);
    }
}
