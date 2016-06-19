using System.Linq;
using System;
using RobotWars.Model;

namespace RobotWars
{
    class RobotConsoleController
    {
        private const char LEFT = 'L';
        private const char RIGHT = 'R';
        private const char MOVE_FORWARD = 'M';

        private readonly IRobot robot;
        private readonly char[] validCommands = new[] { LEFT, RIGHT, MOVE_FORWARD };
        private readonly string invalidCommandMessage;

        public RobotConsoleController(IRobot robot)
        {
            this.robot = robot;
            invalidCommandMessage = string.Format(
                "Movement commands only allows these characters: {0}", string.Join(",", validCommands));
        }

        public void ExecuteCommand(char[] movementCommands)
        {
            if (movementCommands.Except(validCommands).Any())
            {
                throw new ArgumentException(invalidCommandMessage);
            }

            foreach (var commandChar in movementCommands)
            {
                robot.Move(TranslateToRobotCommand(commandChar));
            }
        }

        private RobotCommand TranslateToRobotCommand(char commandString)
        {
            switch(commandString)
            {
                case LEFT:
                    return RobotCommand.TurnLeft;
                case RIGHT:
                    return RobotCommand.TurnRight;
                default:
                    return RobotCommand.MoveForward;
            }
        }
    }
}
