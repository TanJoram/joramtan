using System;
 class Prog5
{
   static void Main()
    {
        int number = 2323233;  
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;   
            if (digit % 2 != 0)       
            {
                sum += digit;
            }
            number /= 10;              
        }

        Console.WriteLine("Sum of odd digits = " + sum);
    }
}
