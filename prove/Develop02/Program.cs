using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string question = prompt.GetRandomPrompt();
                Console.WriteLine(question);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, question, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")  //option to SAVE
            {
                journal.Display();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}