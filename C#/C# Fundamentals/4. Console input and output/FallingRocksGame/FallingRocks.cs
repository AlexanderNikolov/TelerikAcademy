//unfinished!

/* 
* Console.WriteLine("Implement the \"Falling Rocks\" game in the text console. A small dwarf stays at the bottom of
* the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms
* constantly fall down and you need to avoid a crash. Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, -   
* distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150). 
* Implement collision detection and scoring system.");
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Position
{
    public int row;
    public int col;
    public Position(int row, int col)
    {
        this.row = 40;
        this.col = col;
    }

}

class FallingRocks
{
    static void Main()
    {
        Console.Title = "Homework 4 - FallingRocks game";

        Position[] directions = new Position[]
            {
                new Position(0, 1),  //right
                new Position(0, -1), //left
            };

        int direction = 0;

        Queue<Position> dwarfAvatar = new Queue<Position>();

        dwarfAvatar.Enqueue(new Position(40, 0));

        foreach (Position position in dwarfAvatar)
        {
            Console.SetCursorPosition(position.col, position.row);
            Console.Write("("); Console.Write("o"); Console.Write(")");
        }

        while (true)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                direction = 1;
            }
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                direction = 0;
            }

            dwarfAvatar.Dequeue();
            Position dwarfHead = dwarfAvatar.Last();
            Position nextDirection = directions[direction];
            Position dwarfNewHead = new Position(dwarfHead.row, dwarfHead.col + nextDirection.col);

            dwarfAvatar.Enqueue(dwarfNewHead);

            Console.Clear();

            foreach (Position position in dwarfAvatar)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("o");
            }
        }
    }
}