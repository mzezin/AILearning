// Задача 1.
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка и показывает диапазон возможных координат точек в этой четверти (x и y).

// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0


int quarterFind(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    return 0;
}
;

Console.WriteLine("Введите координаты точки:");
Console.WriteLine("X?");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Y?");
int y = int.Parse(Console.ReadLine());
int result = quarterFind(x, y);
if (result == 0)
    Console.WriteLine("Неправильные координаты");
Console.WriteLine($"Точка находится в {result} четверти");



// Point2d classPoint = new Point2d(x, y);
// int classResult = classPoint.getQuarter();

// if (classResult == 0)
//     Console.WriteLine("Неправильные координаты");
// Console.WriteLine($"Точка находится в {classResult} четверти");

// class Point2d
// {
//     public int x;
//     public int y;

//     public Point2d(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }

//     public int getQuarter() {
//       if (this.x > 0 && this.y > 0)
//         return 1;
//     if (this.x > 0 && this.y < 0)
//         return 2;
//     if (this.x < 0 && this.y < 0)
//         return 3;
//     if (this.x < 0 && this.y > 0)
//         return 4;
//     return 0;
//     }
// }
