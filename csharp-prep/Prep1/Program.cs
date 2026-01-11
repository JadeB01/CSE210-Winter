using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string  first = Console.ReadLine();
        //"Console.WriteLine()" is just like "Print" in Python//
        //"Console.Write()" Like "Print" but no next sentence line(?) after//
        //"String" is sjust like input for python. Create a keyword for the input your get, then "= Console.ReadLine();"//
        Console.Write("Whats is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {first} {last}. Nice to meet you!"); 
        //if you want to use the keywards (Variables) that you created, use dollar sign "$"//
    }
}