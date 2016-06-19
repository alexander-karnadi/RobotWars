using RobotWars.Model;
using RobotWars.Navigation;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RobotWars.Gui
{
    class RobotInput
    { 
        public string Name { get; set; }
        public Heading Heading { get; set; }
        public Point Location { get; set; }
        public string RobotCommandsUI
        {
            get
            {
                if(RobotCommands != null)
                {
                    return string.Join(",", RobotCommands.Select(r => r.ToString()));
                }

                return string.Empty;
            }
        }
        public IEnumerable<RobotCommand> RobotCommands { get; set; }
    }
}
