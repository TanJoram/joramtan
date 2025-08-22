using System;

class Prog
{
    static void Main()
    {
        Console.WriteLine("Odd numbers from 1 to 50:");

        int num = 1;
        while (num <= 50)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
            num++;
        }
    }
}
