using System;

class BullAndCows
{
    static void Main()
    {
        int secretNumber = 
             int.Parse(Console.ReadLine());
        int bullsInNumber = 
             int.Parse(Console.ReadLine());
        int cowsInNumber = 
             int.Parse(Console.ReadLine());
        bool solutionFound = false;

        for (int p0 = 1; p0 <= 9; p0++)         {
            for (int p1 = 1; p1 <= 9; p1++)         {
                for (int p2 = 1; p2 <= 9; p2++)         {
                    for (int p3 = 1; p3 <= 9; p3++)         {

                        //positions of digits in number (can be made also with %10 and /10 :)
                        int guess1000 = int.Parse("" + secretNumber.ToString()[0]);
                        int guess100 = int.Parse("" + secretNumber.ToString()[1]);
                        int guess10 = int.Parse("" + secretNumber.ToString()[2]);
                        int guess1 = int.Parse("" + secretNumber.ToString()[3]);

                        int temp0 = p0;
                        int temp1 = p1;
                        int temp2 = p2;
                        int temp3 = p3;
                        int bulls = 0;
                        int cows = 0;

                        if (p0 == guess1000)    
                        {
                            bulls++;
                            guess1000 = - 1;
                            p0 = -2;
                        }
                        
                        if (p1 == guess100)     
                        {
                            bulls++;
                            guess100 = - 1;
                            p1 = -2;
                        }
                        
                        if (p2 == guess10)      
                        {
                            bulls++;
                            guess10 = - 1;
                            p2 = -2;
                        }

                        if (p3 == guess1)    
                        {
                            bulls++;
                            guess1 = - 1;
                            p3 = -2;
                        }

                        if (p0 == guess100)  
                        {
                            cows++;
                            guess100 = - 1;
                        }
                        else if (p0 == guess10)
                        {
                            cows++;
                            guess10 = - 1;
                        }
                        else if (p0 == guess1) 
                        {
                            cows++;
                            guess1 = - 1;
                        }

                        if (p1 == guess1000)  
                        {
                            cows++;
                            guess1000 = - 1;
                        }
                        else if (p1 == guess10)
                        {
                            cows++;
                            guess10 = - 1;
                        }
                        else if (p1 == guess1)
                        {
                            cows++;
                            guess1 = - 1;
                        }

                        if (p2 == guess1000)    
                        {
                            cows++;
                            guess1000 = - 1;
                        }
                        else if (p2 == guess100)
                        {
                            cows++;
                            guess100 = - 1;
                        }
                        else if (p2 == guess1) 
                        {
                            cows++;
                            guess1 = - 1;
                        }

                        if (p3 == guess1000)   
                        {
                            cows++;
                            guess1000 = - 1;
                        }
                        else if (p3 == guess100)
                        {
                            cows++;
                            guess100 = - 1;
                        }
                        else if (p3 == guess10)
                        {
                            cows++;
                            guess10 = - 1;
                        }

                        p0 = temp0;
                        p1 = temp1;
                        p2 = temp2;
                        p3 = temp3;

                        if (bulls == bullsInNumber && cows == cowsInNumber)
                        {
                            if (solutionFound) 
                            {
                                Console.Write(" ");
                            }
                            Console.Write("" + p0 + p1 + p2 + p3);
                            solutionFound = true;
                        }
                    }
                }
            }
        }
        if (!solutionFound)
            Console.WriteLine("No");
    }
}