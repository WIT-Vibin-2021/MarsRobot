using System;

namespace MarsRobot
{
    class Robot
    {
        public int x { get; set; } // Robot x-axis 
        public int y { get; set; } // Robot y-axis

        public string dir; // Moving direction
        string[] str_dir = { "L", "R", "F" };
        private int row_max;
        private int col_max;

        public Robot(int row, int col)
        {            
            row_max = row;
            col_max = col;

            x = 1; // Initial Position
            y = 1; // Initial Position
        }

        public void robot_moving(string command)
        {
            char[] moveCommand = command.ToCharArray();
            for(int i=0; i<= moveCommand.Length;i++)
            {
                if (moveCommand[i]=='L')
                {
                    //Move Left
                }
                else if (moveCommand[i] == 'R')
                {
                    //Move Right
                }
                else if (moveCommand[i] == 'F')
                {
                    //Move forward
                }
                else
                {
                    Console.WriteLine("Invalid Command Value !!");
                }

            }
        }

    }
    internal class Program
    {
        

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
            Robot robotObj = new  Robot( row, col);
        }

       
    }
}
