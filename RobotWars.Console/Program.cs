namespace RobotWars.Console
{
    using System;
    using System.Drawing;
    using System.Collections.Generic;
    using Model;
    using Navigation;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your input:");
                var sizeString = Console.ReadLine();
                var sizeStringSplitted = sizeString.Split(' ');
                var areaSize = new Size(int.Parse(sizeStringSplitted[0]), int.Parse(sizeStringSplitted[1]));

                var navService = new NavigationService(areaSize);
                var robots = new List<Robot>();

                var number = 0;

                var nextInput = Console.ReadLine();
                while (nextInput != string.Empty)
                {
                    var initialPosition = RobotPositionParser.Parse(nextInput);
                    var robot = new Robot($"Robot{++number}", initialPosition, navService);
                    robots.Add(robot);

                    var controller = new RobotConsoleController(robot);
                    var robotMovementCommands = Console.ReadLine();
                    controller.ExecuteCommand(robotMovementCommands.ToCharArray());

                    nextInput = Console.ReadLine();
                }

                foreach (var robot in robots)
                {
                    Console.WriteLine($"{robot.CurrentPosition.Location.X} {robot.CurrentPosition.Location.Y} {robot.CurrentPosition.Heading}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred. Please make sure that the input that you provide are valid.");
                Console.WriteLine($"Original error:\n{ex}");
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
