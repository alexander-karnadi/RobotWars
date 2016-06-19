using System.Drawing;
 
namespace RobotWars.Navigation
{
    public interface INavigationService
    {
        bool IsPositionWithinBoundaries(RobotPosition position);
        RobotPosition MoveOnePointFrom(RobotPosition position);
    }
}
