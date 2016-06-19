using RobotWars.Navigation;

namespace RobotWars.Model
{
    public interface IRobot
    {
        string Name { get; }
        RobotPosition CurrentPosition { get; }
        void Move(RobotCommand command);
    }
}
  