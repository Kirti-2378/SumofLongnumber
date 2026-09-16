using System;
using System.IO;

class Program9
{
    static void Main()
    {
        string file = "student.txt";

        File.WriteAllText(file,
            "Name: Kirti\n" +
            "Roll No: 101\n" +
            "Course: MCA\n" +
            "Marks: 85");
        
        string data = File.ReadAllText(file);

        Console.WriteLine("Student Details:");
        Console.WriteLine(data);
    }
}