using System;

class Prog
{
    static void Main()
    {
        int baseNum = 2;   
        int exp = 5;       

        int result = 1;

        for (int i = 1; i <= exp; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine("{0} raised to the power of {1} = {2}", baseNum, exp, result);
    }
}
