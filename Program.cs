using System;

namespace MarsRobot
{
    internal class Program
    {
        public int x { get; set; } // Robot x-axis
        public int y { get; set; } // Robot y-axis
                

        public string dir; // Moving direction
        string[] str_dir = { "L", "R", "F" };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = Console.ReadLine(); // Grid Input
            string s2 = Console.ReadLine(); // Command Input

            string[] str = s1.Split("x");
            int row = Int32.Parse(str[0]);
            int col = Int32.Parse(str[1]);
            Console.WriteLine(row);
            Console.WriteLine(col);
        }
    }
}
