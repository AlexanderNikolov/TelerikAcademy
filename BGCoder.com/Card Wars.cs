using System;
using System.Numerics;
using System.IO;

public class CardWars
{
    static void Main()
    {
        if (Environment.CurrentDirectory                           
                       .ToLower()                                   
                       .EndsWith("bin\\debug"))                      
        {                                                           
            Console.SetIn(new StreamReader("test.013.in.txt"));     
        }                                                           

        BigInteger outputPlayer1 = 0; 
        BigInteger outputPlayer2 = 0;
        int countP1 = 0;       
        int countP2 = 0;
        bool x1 = false;        //handler for X card
        bool x2 = false;
        int tempP1 = 0;
        int tempP2 = 0;

        int games = int.Parse(Console.ReadLine());

        for (int j = 0; j < games; j++)
        {
            for (int i = 0; i < 6; i++)  //0, 1, 2 - first player hand .. 
            {
                string input = 
                    Console.ReadLine();

                switch (input[0])      
                {
                    case 'A':
                        if (i < 3)  tempP1 += 1;
                        else        tempP2 += 1;  break;
                    case '2':
                        if (i < 3)  tempP1 += 10;  
                        else        tempP2 += 10; break;
                    case '3':
                        if (i < 3)  tempP1 += 9;       
                        else        tempP2 += 9; break;
                    case '4':
                        if (i < 3)  tempP1 += 8;       
                        else        tempP2 += 8; break;
                    case '5':
                        if (i < 3)  tempP1 += 7;       
                        else        tempP2 += 7; break;
                    case '6':
                        if (i < 3)  tempP1 += 6;       
                        else        tempP2 += 6; break;
                    case '7':
                        if (i < 3)  tempP1 += 5;       
                        else        tempP2 += 5; break;
                    case '8':
                        if (i < 3)  tempP1 += 4;       
                        else        tempP2 += 4; break;
                    case '9':
                        if (i < 3)  tempP1 += 3; 
                        else        tempP2 += 3; break;
                    case '1':                 // 10, but we read only first simbol
                        if (i < 3)  tempP1 += 2;
                        else        tempP2 += 2; break;
                    case 'J':
                        if (i < 3)  tempP1 += 11;      
                        else        tempP2 += 11; break;
                    case 'Q':
                        if (i < 3)  tempP1 += 12;
                        else        tempP2 += 12; break;
                    case 'K':
                        if (i < 3)  tempP1 += 13;      
                        else        tempP2 += 13; break;
                    case 'Z':
                        if (i < 3)  outputPlayer1 *= 2;
                        else        outputPlayer2 *= 2; break;
                    case 'Y':
                        if (i < 3)  outputPlayer1 -= 200;
                        else        outputPlayer2 -= 200; break;
                    case 'X':
                        if (i < 3)  x1 = true;
                        else        x2 = true; break;
                }
            }
            //middle logic after every 6 cards (1 game)
            if (x1 && x2)
            {
                outputPlayer1 += 50;
                outputPlayer2 += 50;
            }
            else if (x1)
                break;
            else if (x2)
                break;

            if (tempP1 > tempP2)
            {
                outputPlayer1 += tempP1;
                countP1++;
            }
            else if (tempP1 < tempP2)
            {
                outputPlayer2 += tempP2;
                countP2++;
            }
           
            tempP1 = 0; //zeros to counters - ready for next game
            tempP2 = 0;
            x1 = false;
            x2 = false;
        }
        
        //final results logic and output
        if (x1)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (x2)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (outputPlayer1 > outputPlayer2)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", outputPlayer1);
            Console.WriteLine("Games won: {0}", countP1);
        }
        else if (outputPlayer1 < outputPlayer2)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", outputPlayer2);
            Console.WriteLine("Games won: {0}", countP2);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", outputPlayer1);
        }
        
    }
}

