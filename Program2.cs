using System;

namespace ConsoleApp3
{
    internal class Program2 
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "ABC";
                int b = int.Parse(str);
                int a = 10;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
            }
        }
    }
}