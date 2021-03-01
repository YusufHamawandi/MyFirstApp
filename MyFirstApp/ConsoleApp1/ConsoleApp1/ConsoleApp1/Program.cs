using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.Green;
            
            int value1;
            int value2;

            value1 = GetValue("What Is Your First Value?");

            value2 = GetValue("What Is Your Secound Value?");
            
            WriteResult(value1, value2);

        }
        static int GetValue(string message)
        {
            int value;
            Console.WriteLine(message);
            value = Convert.ToInt32(Console.ReadLine());
            return value;
        }
        static void WriteResult(int v1, int v2)
        {
            int result = v1 + v2;
            Console.WriteLine("Your Result is:");
            Console.WriteLine(result.ToString());

        }
    }
}
