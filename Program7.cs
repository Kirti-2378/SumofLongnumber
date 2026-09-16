
using System;

class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base(message)
    {
    }
}

class Program7
{
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "1234";

        try
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username != correctUsername || password != correctPassword)
            {
                throw new InvalidLoginException("Invalid username or password.");
            }

            Console.WriteLine("Login successful!");
        }
        catch (InvalidLoginException ex)
        {
            Console.WriteLine("Login Failed: " + ex.Message);
        }
    }
}

