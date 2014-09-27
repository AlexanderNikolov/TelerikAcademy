// ----------------------------------------------
//
//      taks from www.BGCoder.com
//
//-----------------------------------------------

using System;

class AngryBits
{
    static void Main(string[] args)
    {
        int[,] matrix = 
            new int[8, 16];

        for (int i = 0; i < 8; i++)                             //
        {                                                       //
            int number =                                        // standard method for management input
                        int.Parse(Console.ReadLine());          // data and prepaire for bitwise operations
                                                                //  
            for (int j = 0; j < 16; j++)                        // (number >> iterator) & 1 
            {                                                   //     - mask for present of bit in position:
                int bit = (number >> j) & 1;                    // 
                                                                //     
                matrix[i, j] = bit;                             //
            }
        }

        int score = 0;

        for (int col = 8; col < 16; col++)
        {
            int currentRow = -1; // find bird flag

            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    currentRow = row;
                    break;
                }
            }

            //logic - killing pigs
            if (currentRow == -1)   
                continue;            
            else                    
            {
                string direction = "up";

                if (currentRow == 0)
                {
                    direction = "down";
                }

                int path = 0; //part of final score
                int pigHitted = 0;
                matrix[currentRow, col] = 0; //remove bird and start moving
                
                for ( int currentColumn = (col - 1); currentColumn >= 0; --currentColumn) // keep bird in 
                {
                    if (direction =="up")
                    {
                        currentRow--;
                        if (currentRow == 0)
                        {
                            direction = "down";
                        }
                    }
                    else               
                    {
                        currentRow++;
                        if (currentRow > 7)
                        {
                            break;
                        }
                    }
                    if (matrix[currentRow, currentColumn] == 1) //hit pig? yes!
                    {
                        path = col - currentColumn;

                        //check for pigs arround hit zone
                        for (int i = currentRow - 1; i <= currentRow + 1; i++) 
                        {
                            for (int j = currentColumn - 1; j <= currentColumn + 1; j++)
                            {
                                // limits of matrix checking
                                if (i > -1 && i < 8 && j > -1) 
                                {
                                    if (matrix[i, j] == 1)
                                    {
                                        pigHitted++;
                                        matrix[i, j] = 0;
                                    }
                                }
                            }
                        }
                    }
                    if (pigHitted >= 1)  break;
                }
                score = score + path * pigHitted;
            }
        }
        string result = "Yes";

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] == 1)
                {
                    result = "No";
                    break;
                }
            }
        }
        Console.WriteLine("{0} {1}", score, result);
    }
}