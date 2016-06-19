using RobotWars.Navigation;
using System;
using System.Drawing;

namespace RobotWars.Console
{
    static class RobotPositionParser
    {
        public static RobotPosition Parse(string input)
        {
            try
            {
                var robotPositionSplitted = input.Split(' ');
                var heading = ConvertToHeading(robotPositionSplitted[2]);
                var position = new RobotPosition
                {
                    Location = new Point(int.Parse(robotPositionSplitted[0]), int.Parse(robotPositionSplitted[1])),
                    Heading = heading
                };

                return position;
            }
            catch(Exception ex)
            {
                throw new ArgumentException($"Input is incorrect. Make sure you define starting point and heading like this example: 1 2 E (means point X:1 Y:2 heading East). Original error: {ex}");
            }
        }

        private static Heading ConvertToHeading(string headingString)
        {
            switch (headingString)
            {
                case "E":
                    return Heading.East;
                case "N":
                    return Heading.North;
                case "S":
                    return Heading.South;
                case "W":
                    return Heading.West;
                default:
                    throw new ArgumentException("Heading values are: N, E, S, W");
            }
        }
    }


}
