int[,] number = { {0,0,0,0,0,0,0},
                  {0,0,0,0,2,0,0},
                  {0,0,0,0,2,0,0},
                  {0,0,0,1,2,0,0},
                  {0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0}};
// int row = int.Parse(Console.ReadLine());
// int column = int.Parse(Console.ReadLine());
// int[,] num = new int[row, column];
// for (int i = 0; i < number.GetLength(0); i++)
// {
//     for (int j = 0; j < number.GetLength(1); j++)
//     {
//         Console.Write(number[i, j] + " ");
//     }
//     Console.WriteLine();
// }
int row = 3;
int column = 3;
int oldRow = 0;
int oldColumn = 0;
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    number[row, column] = 0;
    oldRow = row;
    oldColumn = column;
    if (key.Key == ConsoleKey.W)
    {
        row--;
    }
    if (key.Key == ConsoleKey.S)
    {
        row++;
    }

    if (key.Key == ConsoleKey.A)
    {
        column--;
    }

    if (key.Key == ConsoleKey.D)
    {
        column++;
    }
    if (row > number.GetLength(0) - 1)
    {
        row = number.GetLength(0) - 1;
    }
    if (row < 0)
    {
        row = 0;
    }
    if (column > number.GetLength(1) - 1)
    {
        column = number.GetLength(1) - 1;
    }
    if (column < 0)
    {
        column = 0;
    }
    Console.Clear();
    if (number[row, column] == 2)
    {
        row = oldRow;
        column = oldColumn;
    }
    number[row, column] = 1;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();
    }
}

