using System;

class TicTacToePower
{
    static void Main()
    {
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        int v = Int32.Parse(Console.ReadLine());
        int addon= 0;
        long power = 1;
        int[,] board = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i,j] = v + addon;
                addon++;
            }
        }
        int index = board[y, x] - board[0, 0]+1;
        for (int i = 0; i < index; i++)
        {
            power *= board[y, x];
        }
        Console.WriteLine(power);
    }
}
