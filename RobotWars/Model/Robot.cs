using System;
using RobotWars.Navigation;

namespace RobotWars.Model
{
    public class Robot : IRobot 
    {
        private RobotPosition currentPosition;
        private INavigationService navigationService;
        private string name;

        public Robot(string name, RobotPosition position, INavigationService navigationService)
        {
            if (!navigationService.IsPositionWithinBoundaries(position))
                throw new ArgumentOutOfRangeException("position", "Starting position is out of bound of the battle area.");

            currentPosition = position;
            this.navigationService = navigationService;
            this.name = name;
        }

        public RobotPosition CurrentPosition
        {
            get
            {
                return currentPosition;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Move(RobotCommand command)
        {
            switch(command)
            {
                case RobotCommand.MoveForward:
                    MoveForward();
                    break;
                case RobotCommand.TurnLeft:
                    Turn(TurnDirection.Left);
                    break;
                case RobotCommand.TurnRight:
                    Turn(TurnDirection.Right);
                    break;
                default:
                    throw new ArgumentException("Robot command is unknown.");
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            var otherRobot = obj as Robot;
            if (otherRobot == null)
                return false;

            return Name == otherRobot.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {CurrentPosition}";
        }

        private void MoveForward()
        {
            currentPosition = navigationService.MoveOnePointFrom(currentPosition);
        }

        private void Turn(TurnDirection newDirection)
        {
            currentPosition.Turn(newDirection);
        }
    }
}
