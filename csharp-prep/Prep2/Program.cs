using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string user = Console.ReadLine();
        int percent = int.Parse(user);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! Good job!");
        }
        else
        {
            Console.WriteLine("You did not pass, study hard next time!");
        }


    }
}