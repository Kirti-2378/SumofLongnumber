using System;
using System.IO;

class Program10
{
    static void Main()
    {
        try
        {
            string[] lines = File.ReadAllLines("marks.txt");

            int total = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            foreach (string line in lines)
            {
                int mark = int.Parse(line);

                if (mark < 0 || mark > 100)
                    throw new Exception("Marks must be between 0 and 100.");

                total += mark;

                if (mark > highest)
                    highest = mark;

                if (mark < lowest)
                    lowest = mark;
            }

            double average = (double)total / lines.Length;

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Highest: " + highest);
            Console.WriteLine("Lowest: " + lowest);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid mark in file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
