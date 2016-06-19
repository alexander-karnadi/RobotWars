using System.Drawing;

namespace RobotWars.Navigation
{
    public class NavigationService : INavigationService
    {
        private readonly Size arenaSize;

        public NavigationService(Size arenaSize)
        {
            this.arenaSize = arenaSize;
        }

        public bool IsPositionWithinBoundaries(RobotPosition position)
        {
            return position.Location.X <= arenaSize.Width &&
                position.Location.X >= 0 &&
                position.Location.Y <= arenaSize.Height &&
                position.Location.Y >= 0;
        }

        public RobotPosition MoveOnePointFrom(RobotPosition position)
        {
            var location = position.Location;
            switch (position.Heading)
            {
                case Heading.North:
                    location.Y += 1;
                    break;
                case Heading.East:
                    location.X += 1;
                    break;
                case Heading.South:
                    location.Y -= 1;
                    break;
                default:
                    location.X -= 1;
                    break;
            }
            
            position.Location = AdjustPositionIfNeeded(location);

            return position;
        }

        private Point AdjustPositionIfNeeded(Point location)
        {
            // if position is out of bound adjust to max point or min point
            location.Y = location.Y > arenaSize.Height ? arenaSize.Height : location.Y <= 0 ? 0 : location.Y;
            location.X = location.X > arenaSize.Width ? arenaSize.Width : location.X <= 0 ? 0 : location.X;

            return location;
        }
    }
}
