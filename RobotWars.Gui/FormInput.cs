using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RobotWars.Model;
using RobotWars.Navigation;

namespace RobotWars.Gui
{ 
    public partial class FormInput : Form
    {
        private BindingSource robotsBindingSource;

        public FormInput()
        {
            InitializeComponent();

            robotsBindingSource = new BindingSource();
            robotsBindingSource.DataSource = typeof(RobotInput);

            dataGridViewRobotInput.DataSource = robotsBindingSource;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            listBoxCommand.Items.Add(RobotCommand.TurnLeft);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            listBoxCommand.Items.Add(RobotCommand.TurnRight);
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            listBoxCommand.Items.Add(RobotCommand.MoveForward);
        }

        private void buttonAddRobot_Click(object sender, EventArgs e)
        {
            if (!IsRobotInputValid())
            {
                MessageBox.Show("Robot input is invalid. Make sure all fields are filled.", "Robot Input");
                return;
            }

            if (AnyRobotWithSameName())
            {
                MessageBox.Show("Robot with the same name has been defined. Please insert a different name.", "Robot Input");
                return;
            }

            var commands = new List<RobotCommand>();
            foreach (var obj in listBoxCommand.Items)
            {
                commands.Add((RobotCommand)obj);
            }

            var robotInput = new RobotInput
            {
                Name = textBoxName.Text,
                Location = new Point((int)numericUpDownPositionX.Value, (int)numericUpDownPositionY.Value),
                Heading = ConvertToHeading(comboBoxInitialHeading.SelectedItem.ToString()),
                RobotCommands = commands
            };

            robotsBindingSource.Add(robotInput);
        }

        private bool AnyRobotWithSameName()
        {
            return robotsBindingSource.Count > 0 && robotsBindingSource.Cast<RobotInput>().Any(b => b.Name == textBoxName.Text);
        }

        private bool IsRobotInputValid()
        {
            return !string.IsNullOrWhiteSpace(textBoxName.Text) 
                && comboBoxInitialHeading.SelectedItem != null 
                && listBoxCommand.Items != null 
                && listBoxCommand.Items.Count > 0;
        }

        private static Heading ConvertToHeading(string value)
        {
            switch(value)
            {
                case "North":
                    return Heading.North;
                case "East":
                    return Heading.East;
                case "South":
                    return Heading.South;
                default:
                    return Heading.West;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            var height = (int)numericUpDownHeight.Value;
            var width = (int)numericUpDownWidth.Value;

            if(height == 0 || width == 0 || robotsBindingSource.Count == 0)
            {
                MessageBox.Show("Unable to render battle situation. Size needs to be bigger than 0 and one or more robots need to be added.");
                return;
            }

            var battleArea = new Size(width, height);

            var navigationService = new NavigationService(battleArea);
            var robots = new List<Robot>();

            foreach (var input in robotsBindingSource)
            {
                var robotInput = (RobotInput)input;
                Robot robot;
                try
                {
                    robot = new Robot(
                        robotInput.Name, 
                        new RobotPosition
                        {
                            Location = robotInput.Location,
                            Heading = robotInput.Heading
                        }, 
                        navigationService);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    // TODO: log
                    MessageBox.Show($"Error when creating robot. Make sure your input is valid. Original error: {ex}");
                    return;
                }
                var commands = robotInput.RobotCommands;

                foreach (var command in commands)
                {
                    robot.Move(command);
                }

                robots.Add(robot);
            }

            var formBattle = new FormBattle();
            formBattle.RenderBattleSituation(battleArea, robots);
            formBattle.Show(this);
        }

        private void ResetInput()
        {
            numericUpDownHeight.Value = 0;
            numericUpDownWidth.Value = 0;
            numericUpDownPositionX.Value = 0;
            numericUpDownPositionY.Value = 0;
            textBoxName.Text = "";
            comboBoxInitialHeading.SelectedItem = null;
            listBoxCommand.Items.Clear();
            robotsBindingSource.Clear();
        }

        private void buttonClearCommand_Click(object sender, EventArgs e)
        {
            listBoxCommand.Items.Clear();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
    }
}
