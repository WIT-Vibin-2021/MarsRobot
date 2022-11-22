using System;

namespace MarsRobot
{
    class Robot
    {
        public int x { get; set; } // Robot x-axis 
        public int y { get; set; } // Robot y-axis

        public string dir; // Moving direction
        //string[] str_dir = { "NORTH", "EAST", "SOUTH","WEST" };
        private int row_max;
        private int col_max;

        public Robot(int row, int col)
        {            
            row_max = row;
            col_max = col;

            x = 1; // Initial Position
            y = 1; // Initial Position
            dir = "NORTH";
        }

        public void robot_moving_forward()
        {
            // Considering Y - Axis for North-South
            // Considering x - Axis for East-West
            switch (dir)
            {
                case "NORTH":  // Add Y Axis to move North
                    if (y < row_max)
                        y++;
                    break;
                case "SOUTH":  // Reduce Y Axis to move South (opposit of North)
                    if (y>0)
                        y--;
                    break;
                case "EAST": // Add X Axis to move East
                    if (x < col_max)
                        x++;
                    break;
                case "WEST": // Reduce X Axis to move West (opposit of East)
                    if (x > 0)
                        x--;
                    break;
                default:
                    break;
            }

        }
        /* 
         North + Left = West
         North + Right = East

         South + Left = East
         South + Right = West

         East + Left = North
         East + Right =South

         West + Left = South
         West + Right = North
        */

        public void robot_moving_left()
        {
            if (dir == "NORTH")
                dir = "WEST";
            else if (dir == "SOUTH")
                dir = "EAST";
            else if (dir == "EAST")
                dir = "NORTH";
            else if (dir == "WEST")
                dir = "SOUTH";
        }
        public void robot_moving_right()
        {
            if (dir == "NORTH")
                dir = "EAST";
            else if (dir == "SOUTH")
                dir = "WEST";
            else if (dir == "EAST")
                dir = "SOUTH";
            else if (dir == "WEST")
                dir = "NORTH";
        }
        public void robot_moving(string command)
        {
            char[] moveCommand = command.ToCharArray();
            for(int i=0; i< moveCommand.Length;i++)
            {
                if (moveCommand[i]=='L')
                {
                    robot_moving_left();
                }
                else if (moveCommand[i] == 'R')
                {
                    robot_moving_right();
                }
                else if (moveCommand[i] == 'F')
                {
                    robot_moving_forward();
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
            robotObj.robot_moving(s2);
            Console.WriteLine(robotObj.x + " " + robotObj.y + " " + robotObj.dir);
        }

       
    }
}
