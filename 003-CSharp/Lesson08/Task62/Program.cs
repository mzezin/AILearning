// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Spiral spiral = new Spiral();
spiral.Print();

class Spiral
{
    int[,] Data;
    int Height;
    int Width;
    int ElementCount;
    int X;
    int Y;
    int SpeedX;
    int SpeedY;
    int CurrentNumber;
    Directions Direction;

    public Spiral(int height = 4, int width = 4)
    {
        Height = height;
        Width = width;
        Data = new int[height, width];
        X = 0;
        Y = 0;
        CurrentNumber = 1;
        ElementCount = height * width;
        Direction = Directions.East;
        SpeedX = 1;
        SpeedY = 0;
        for (int i = 1; i <= ElementCount; i++)
        {
            FillCell();
            if (!CanMoveForward())
                RotateClockwise();
            MoveForward();
        }
    }

    public void Print()
    {
        int cellWidth = ElementCount.ToString().Length;
        string result = "";
        for (int i = 0; i < Data.GetLength(0); i++)
        {
            for (int j = 0; j < Data.GetLength(1); j++)
            {
                string prefix = "";
                for (int l = 0; l < cellWidth - Data[i, j].ToString().Length; l++)
                {
                    prefix += "0";
                }
                result += prefix + Data[i, j] + " ";
            }
            result += "\n";
        }
        Console.WriteLine(result);
    }

    public int[,] ToArray()
    {
        return Data;
    }

    void FillCell()
    {
        Data[Y, X] = CurrentNumber;
        CurrentNumber++;
    }

    void RotateClockwise()
    {
        switch (Direction)
        {
            case Directions.East:
                Direction = Directions.South;
                SpeedX = 0;
                SpeedY = 1;
                break;
            case Directions.South:
                Direction = Directions.West;
                SpeedX = -1;
                SpeedY = 0;
                break;
            case Directions.West:
                Direction = Directions.North;
                SpeedX = 0;
                SpeedY = -1;
                break;
            case Directions.North:
                Direction = Directions.East;
                SpeedX = 1;
                SpeedY = 0;
                break;
        }
    }

    bool CanMoveForward()
    {
        //проверка на "выход за внешние границы"
        if ((X + SpeedX >= Width) || (Y + SpeedY >= Height) || (X + SpeedX < 0) || (Y + SpeedY < 0))
            return false;
        //проверка на "переход на заполненную ячейку"
        if (Data[Y + SpeedY, X + SpeedX] != 0)
            return false;
        return true;
    }

    void MoveForward()
    {
        X += SpeedX;
        Y += SpeedY;
    }
}

enum Directions
{
    North,
    East,
    South,
    West
}
