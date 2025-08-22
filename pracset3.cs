using System;
class Prog3
{
    static void Main()
    {
        int age = 19;
        int salary = 10000;

        if (age >= 25 && age <= 35 && salary > 50000)
            Console.WriteLine("You are Young Professional");
        else if (age >= 36 && age <= 55 && salary > 70000)
            Console.WriteLine("You are Middle-aged Professional");
        else if (age >= 56 && salary < 30000)
            Console.WriteLine("You are Senior Citizen");
        else
            Console.WriteLine("You are working student");
    }
}
