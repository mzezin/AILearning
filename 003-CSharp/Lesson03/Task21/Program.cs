// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.5


// вариант 1: базовый
Console.WriteLine("Введите координаты точки А:");
Console.WriteLine("AX?");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("AY?");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("AZ?");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("BX?");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("BY?");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("BZ?");
int bz = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(
    Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)
);
Console.WriteLine(distance);

// вариант 2: контроль ввода и класс

try
{
    Console.WriteLine("Введите координаты первой точки, разделенные пробелом:");
    List<int> pointA = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

    Console.WriteLine("Введите координаты второй точки, разделенные пробелом:");
    List<int> pointB = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

    if (pointA.Count != 3 || pointB.Count != 3)
        throw (new Exception());
    Point3d classPointA = new Point3d(pointA);
    Point3d classPointB = new Point3d(pointB);

    double classDistance = classPointA.distanceTo(classPointB);

    Console.WriteLine($"Расстояние между точками: {classDistance}");
}
catch (Exception)
{
    Console.WriteLine("Введены неправильные координаты");
}

class Point3d
{
    public int x;
    public int y;
    public int z;

    public Point3d(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Point3d(List<int> point)
    {
        this.x = point[0];
        this.y = point[1];
        this.z = point[2];
    }

    public double distanceTo(Point3d point)
    {
        return Math.Sqrt(
            Math.Pow(point.x - this.x, 2)
                + Math.Pow(point.y - this.y, 2)
                + +Math.Pow(point.z - this.z, 2)
        );
    }
}
