using System;
using System.Linq;

class BitBall
{
    static void Main(string[] args)
    {
        int[,] topPlayers = new int[8, 8];
        int[,] bottomPlayers = new int[8, 8];
        int[,] field = new int[8, 8];


        for (int i = 0; i < 8; i++)
        {
            int input = 
                 int.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                topPlayers[i, j] = (input >> j) & 1;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            int input = 
                 int.Parse(Console.ReadLine());

            for (int j = 0; j < 7; j++)
            {
                bottomPlayers[i, j] = (input >> j) & 1;
            }
        }

        int scoreTop = 0;
        int scoreBot = 0;



    }
}

