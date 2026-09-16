using System;

namespace ConsoleApp3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 15, 12, 36, 45, 78 };
                Console.WriteLine(arr[6]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }
    }
}