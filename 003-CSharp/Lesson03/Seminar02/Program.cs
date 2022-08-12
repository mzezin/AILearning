// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double getDistance(int ax, int ay, int bx, int by)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
}
;

Console.WriteLine("Введите координаты точки А:");
Console.WriteLine("AX?");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("AY?");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("BX?");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("BY?");
int by = int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между точками: {getDistance(ax, ay, bx, by)}");

// Point2d classPointA = new Point2d(ax, ay);
// Point2d classPointB = new Point2d(bx, by);

// double classDistance = classPointA.distanceTo(classPointB);

// Console.WriteLine($"Расстояние между точками: {classDistance}");

// class Point2d
// {
//     public int x;
//     public int y;

//     public Point2d(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }

//     public int getQuarter()
//     {
//         if (this.x > 0 && this.y > 0)
//             return 1;
//         if (this.x > 0 && this.y < 0)
//             return 2;
//         if (this.x < 0 && this.y < 0)
//             return 3;
//         if (this.x < 0 && this.y > 0)
//             return 4;
//         return 0;
//     }

//     public double distanceTo(Point2d point)
//     {
//         return Math.Sqrt(Math.Pow(point.x - this.x, 2) + Math.Pow(point.y - this.y, 2));
//     }
// }
