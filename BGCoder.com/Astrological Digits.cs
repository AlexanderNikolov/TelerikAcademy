using System;

class AstroDigits
{
    static void Main(string[] args)
    {

        ulong sum = 0;

        //manage input data
        while (true)
        {
            int input =
                Console.Read();

            if (input == (char)13 || input == -1)       //char 13 - carriage return
                break;

            if (input >= '0' && input <= '9')
            {
                sum += 
                    (ulong)input - (ulong)'0';
            }

        }
        //output logic
        ulong result = 0;
        
        while (sum > 0)
        {
            ulong temp = sum % 10;
            result += temp;
            sum /= 10;
        }
        
        Console.WriteLine(result);
    }
}

