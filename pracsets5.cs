using System;

class Prog5
{
    static void Main()
    {
        double radius;
        Console.WriteLine("Choose what to compute");
        Console.WriteLine("[A] Compute Area");
        Console.WriteLine("[P] Compute Perimeter");
        Console.WriteLine("[X] Exit");
        Console.Write("Enter the letter of your choice (Capital Letter): ");
        
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case 'A':
                Console.Write("\nEnter the radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine("The area is: {0}", area);
                break;

            case 'P':
                Console.Write("\nEnter the radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                double perimeter = 2 * Math.PI * radius;
                Console.WriteLine("The perimeter is: {0}", perimeter);
                break;

            case 'X':
                Console.WriteLine("Exited");
                return;

            default:
                Console.WriteLine("Not in choices");
                break;
        }
    }
}
