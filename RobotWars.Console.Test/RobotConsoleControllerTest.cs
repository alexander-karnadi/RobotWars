using Moq;
using NUnit.Framework;
using RobotWars.Model;
using System;
using System.Linq.Expressions;

namespace RobotWars.Console.Test
{
    [TestFixture]
    class RobotControllerTest
    {
        [TestCaseSource("validDataTestCase")]
        public void InputTest(char[] commandInput, Expression<Action<IRobot>>[] expectedSequenceOfCommands)
        {
            var robot = new Mock<IRobot>();
            var controller = new RobotConsoleController(robot.Object);
            var robotSequence = new MockSequence();
            foreach (var command in expectedSequenceOfCommands)
            {
                robot.InSequence(robotSequence).Setup(command);
            }

            controller.ExecuteCommand(commandInput);
            robot.VerifyAll();
        }

        [TestCaseSource("invalidDataTestCase")]
        public void InvalidInputTest(char[] commands)
        {
            var controller = new RobotConsoleController(It.IsAny<IRobot>());
            Assert.Throws<ArgumentException>(new TestDelegate(() => controller.ExecuteCommand(commands)));
        }

        static object[] validDataTestCase = new object[]
        {
            new object[]
            {
                new char[] {'L','M','L','R'},
                new Expression<Action<IRobot>>[]
                {
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.TurnRight),
                },
            }
        };

        static object[] invalidDataTestCase = new object[]
        {
            new char[] {'L','M','L','O'},
            new char[] {'B','M'},
        };
    }
}
