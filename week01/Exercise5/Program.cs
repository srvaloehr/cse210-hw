using System;

class Program
{
    static void Main()
    {
        ShowWelcome();

        string name = GetName();
        int number = GetNumber();

        int square = Square(number);

        ShowResult(name, square);
    }

    static void ShowWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
