Sudoku sudoku = new Sudoku();
sudoku.Print();

// sudoku.Print();

class Sudoku
{
    int[,] Data;

    Coords CurrentCoords;
    int CurrentCellIndex;
    List<HistoryItem> History;

    public Sudoku()
    {
        Data = new int[9, 9];
        History = new List<HistoryItem> { };
        for (CurrentCellIndex = 0; CurrentCellIndex < 81; CurrentCellIndex++)
        {
            CurrentCoords = GetCoordsAtIndex(CurrentCellIndex);
            int value = RandomFill(CurrentCoords);
            if (value != 0)
                SaveHistory();
            else
                RollBack();
        }
        // for (int i = 0; i < 9; i++)
        // {
        //     for (int j = 0; j < 9; j++)
        //     {
        //         CurrentCoords = new Coords(j, i);
        //         int value = RandomFill(j, i);
        //         if (value != 0)
        //             SaveHistory();
        //         else
        //         {
        //             RollBack();
        //             if (j == 0)
        //             {
        //                 j = 8;
        //                 i--;
        //             }
        //             else
        //                 j--;
        //         }
        //     }
        // }
    }

    public void Print()
    {
        string result = "";
        for (int i = 0; i < Data.GetLength(0); i++)
        {
            for (int j = 0; j < Data.GetLength(1); j++)
            {
                result += Data[i, j] + " ";
            }
            result += "\n";
        }
        Console.WriteLine(result);
    }

    public void PrintHistory(int index = 0)
    {
        if (History.Count <= 0)
        {
            Console.WriteLine("No data");
            return;
        }
        HistoryItem historyItem = History.ElementAt(index);

        string result = "";
        for (int i = 0; i < historyItem.Data.GetLength(0); i++)
        {
            for (int j = 0; j < historyItem.Data.GetLength(1); j++)
            {
                result += historyItem.Data[i, j] + " ";
            }
            result += "\n";
        }
        Console.WriteLine(result);
    }

    void SaveHistory()
    {
        HistoryItem historyItem = new HistoryItem(Data, CurrentCoords);
        History.Insert(0, historyItem);
    }

    public void RollBack()
    {
        if (History.Count > 0)
        {
            Data = History.ElementAt(0).Data;
            History.RemoveAt(0);
        }
    }

    int[] CalculatePossibleValues(int x, int y)
    {
        List<int> result = new List<int> { };
        for (int i = 1; i <= 9; i++)
        {
            if (CheckPossibility(x, y, i))
                result.Add(i);
        }
        return result.ToArray();
    }

    bool CheckRow(int y, int value)
    {
        for (int i = 0; i < 9; i++)
        {
            if (value == Data[y, i])
                return false;
        }
        return true;
    }

    bool CheckColumn(int x, int value)
    {
        for (int i = 0; i < 9; i++)
        {
            if (value == Data[i, x])
                return false;
        }
        return true;
    }

    bool CheckSector(int x, int y, int value)
    {
        //TODO
        return true;
    }

    bool CheckPossibility(int x, int y, int value)
    {
        return CheckSector(x, y, value) && CheckColumn(x, value) && CheckRow(y, value);
    }

    int RandomNumber(int[] possibleValues)
    {
        if (possibleValues.Length == 0)
            return 0;
        return possibleValues[new Random().Next(0, possibleValues.Length)];
    }

    int RandomNumber()
    {
        return new Random().Next(1, 10);
    }

    public int RandomFill(Coords coords)
    {
        int x = coords.X;
        int y = coords.Y;
        int value = RandomNumber(CalculatePossibleValues(x, y));
        Data[y, x] = value;
        return value;
    }

    Coords GetCoordsAtIndex(int index)
    {
        int counter = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (counter == index)
                    return new Coords(j, i);
                counter++;
            }
        }
        return new Coords(-1, -1);
    }
}

struct Coords
{
    public int X;
    public int Y;

    public Coords(int x, int y)
    {
        X = x;
        Y = y;
    }
}

struct HistoryItem
{
    public Coords Coords;
    public int[,] Data;

    public HistoryItem(int[,] data, Coords coords)
    {
        Coords = coords;
        Data = (int[,])data.Clone();
    }
}
