using System;
using System.Linq;

class Bittris
{
    static void Main(string[] args)
    {
        int commandLines =
            int.Parse(Console.ReadLine());
        int score = 0;
        int count = 0;

        while (true)
        {
            count++;
            if (count > commandLines)
            {
                Console.WriteLine(score);
                break;
            }

            uint shapeTop = uint.Parse(Console.ReadLine());       //shape appear at top line
            uint shape1 = 0;
            uint shape2 = 0;
            uint shapeBottom = 0;
            int scoreBonus = 0;

            for (int j = 0; j < 32; j++)
            {
                if ((shapeTop & (1 << j)) != 0)
                {
                    scoreBonus += 1;
                }
            }

            uint borderLeftMask = (uint)128;
            uint borderRightMask = (uint)1;
            uint fullMask = (uint)255;

            for (int cicle = 1; cicle < 4; cicle++)
            {
                char input =
                    char.Parse(Console.ReadLine());        //input command D, L or R every cicle

                switch (input)
                {
                    case 'D':
                        if (count == 1)
                        {
                            shape1 |= shapeTop;
                            shapeTop &= fullMask;    //zeros to upper line (shape already moved down)
                        }
                        goto default;
                    case 'L':
                        if ((borderLeftMask) == 0)
                        {

                        } goto default;
                    case 'R':
                        if (borderRightMask == 0)
                        {


                        } goto default;
                    default:
                        if (true)
                        {

                        }
                        break;
                }
            }
        }
    }
}

