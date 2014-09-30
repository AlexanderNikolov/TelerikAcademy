namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
    /// The cards should be printed with their English names. Use nested for loops and switch-case.
    /// </summary>
    class CardDeckPrinting
    {
        static void Main()
        {
            const int COLORS = 4;
            const int RANKS = 13;

            int key;

            for (int color = 0; color < COLORS; color++)
            {
                for (int card = 0; card < RANKS; card++)
                {
                    key = card + 1;

                    switch (key)
                    {
                        case 1:
                            Console.Write("Ace  "); goto case 14;
                        case 2:
                            Console.Write("Two  "); goto case 14;
                        case 3:
                            Console.Write("Three"); goto case 14;
                        case 4:
                            Console.Write("Four "); goto case 14;
                        case 5:
                            Console.Write("Five "); goto case 14;
                        case 6:
                            Console.Write("Six  "); goto case 14;
                        case 7:
                            Console.Write("Seven"); goto case 14;
                        case 8:
                            Console.Write("Eight"); goto case 14;
                        case 9:
                            Console.Write("Nine "); goto case 14;
                        case 10:
                            Console.Write("Ten  "); goto case 14;
                        case 11:
                            Console.Write("Jack "); goto case 14;
                        case 12:
                            Console.Write("Qeen "); goto case 14;
                        case 13:
                            Console.Write("King "); goto case 14;
                        case 14:
                            if (color == 0) { Console.WriteLine(" of \u2663"); break; }
                            else
                                goto case 15;
                        case 15:
                            if (color == 1) { Console.WriteLine(" of \u2666"); break; }
                            else
                                goto case 16;
                        case 16:
                            if (color == 2) { Console.WriteLine(" of \u2665"); break; }
                            else
                                goto case 17;
                        case 17:
                            Console.WriteLine(" of \u2660");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}