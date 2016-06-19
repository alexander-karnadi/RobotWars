using System.Drawing;

namespace RobotWars.Navigation
{ 
    public struct RobotPosition
    {
        public Heading Heading { get; set; }

        public Point Location { get; set; }

        internal void Turn(TurnDirection direction)
        {
            switch (direction)
            {
                case TurnDirection.Right:
                    if (Heading != Heading.West)
                    {
                        Heading += 1;
                    }
                    else
                    {
                        Heading = Heading.North;
                    }
                    break;
                default:
                    if (Heading != Heading.North)
                    {
                        Heading -= 1;
                    }
                    else
                    {
                        Heading = Heading.West;
                    }
                    break;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is RobotPosition)
            {
                var otherPosition = (RobotPosition)obj;
                return Heading == otherPosition.Heading && Location == otherPosition.Location;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Heading: {Heading}, Location: {Location}";
        }
    }
}
