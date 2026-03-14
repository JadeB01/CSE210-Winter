using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3.Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Quit");

            Console.Write("Select option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                string type = Console.ReadLine();

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }

                else if (type == "2")
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }

                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new CheckListGoal(name, desc, points, target, bonus));
                }
            }

            else if (input == "2")
            {
                foreach (Goal g in goals)
                {
                    g.DisplayGoal();
                }
            }

            else if (input == "3")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i+1}. ");
                    goals[i].DisplayGoal();
                }

                Console.Write("Select goal: ");
                int index = int.Parse(Console.ReadLine()) - 1;

                score += goals[index].RecordEvent();

                Console.WriteLine($"You earned points! Total score: {score}");
            }

            else if (input == "4")
            {
                Console.WriteLine($"Score: {score}");
            }

            else if (input == "5")
            {
                break;
            }
        }
    }
}