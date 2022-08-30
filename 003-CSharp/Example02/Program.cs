int[,,] sudoku = new int[9, 9, 9];

void populateWithZeroes(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = 0;
            }
        }
    }
}

void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string output1 = String.Format(
                "|{0,3}|{1,3}|{2,3}|",
                array[i, j, 0],
                array[i, j, 1],
                array[i, j, 2]
            );
            string output2 = String.Format(
                "|{0,3}|{1,3}|{2,3}|",
                array[i, j, 3],
                array[i, j, 4],
                array[i, j, 5]
            );
            string output3 = String.Format(
                "|{0,3}|{1,3}|{2,3}|",
                array[i, j, 6],
                array[i, j, 7],
                array[i, j, 8]
            );
            Console.WriteLine("------------------------");
            Console.WriteLine(output1);
            Console.WriteLine("------------------------");
            Console.WriteLine(output2);
            Console.WriteLine("------------------------");
            Console.WriteLine(output3);
            Console.WriteLine("------------------------");
        }
    }
}

populateWithZeroes(sudoku);
printArray(sudoku);


// Sectors indexes
//  -----
// |0|1|2|
// |3|4|5|
// |6|7|8|
//  -----


public class Cell
{
    public int x { get; set; }
    public int y { get; set; }
    public int value { get; set; }

    Cell(int sector, int position, int value){
      switch (sector, position)
      {
        case (0,0): {x=0; y=0;}; break;
        case (0,1): {x=0; y=0;}; break;
        case (0,2): {x=0; y=0;}; break;
        case (0,3): {x=0; y=0;}; break;
        case (0,4): {x=0; y=0;}; break;
        case (0,5): {x=0; y=0;}; break;
        case (0,6): {x=0; y=0;}; break;
        case (0,7): {x=0; y=0;}; break;
        case (0,8): {x=0; y=0;}; break;
        case (1,0): {x=0; y=0;}; break;
        case (1,1): {x=0; y=0;}; break;
        case (1,2): {x=0; y=0;}; break;
        case (1,3): {x=0; y=0;}; break;
        case (1,4): {x=0; y=0;}; break;
        case (1,5): {x=0; y=0;}; break;
        case (1,6): {x=0; y=0;}; break;
        case (1,7): {x=0; y=0;}; break;
        case (1,8): {x=0; y=0;}; break;
        case (2,0): {x=0; y=0;}; break;
        case (2,1): {x=0; y=0;}; break;
        case (2,2): {x=0; y=0;}; break;
        case (2,3): {x=0; y=0;}; break;
        case (2,4): {x=0; y=0;}; break;
        case (2,5): {x=0; y=0;}; break;
        case (2,6): {x=0; y=0;}; break;
        case (2,7): {x=0; y=0;}; break;
      }
    }
}
