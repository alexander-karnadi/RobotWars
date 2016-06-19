using NUnit.Framework;
using RobotWars.Navigation;
using RobotWars.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using Moq;

namespace RobotWars.Test
{
    [TestFixture] 
    class RobotTest
    {
        [TestCaseSource("moveTestCases")]
        public void MoveTest(
            Size areaSize, 
            RobotPosition initialPosition, 
            IEnumerable<Action<IRobot>> robotTestActions, 
            RobotPosition expectedPosition)
        {
            var navigationService = new NavigationService(areaSize);
            var subject = new Robot("name", initialPosition, navigationService);

            foreach (var action in robotTestActions)
            {
                action(subject);
            }

            Assert.That(subject.CurrentPosition, Is.EqualTo(expectedPosition));
        }

        [TestCaseSource("outOfBoundTestCases")]
        public void OutOfBoundTest(Point robotLocation)
        {
            var alwaysFaileNavigationService = new Mock<INavigationService>();
            alwaysFaileNavigationService.Setup(a => a.IsPositionWithinBoundaries(It.IsAny<RobotPosition>())).Returns(false);

            var position = new RobotPosition { Heading = Heading.East, Location = robotLocation };
            Assert.Throws<ArgumentOutOfRangeException>(() => new Robot(It.IsAny<string>(), position, alwaysFaileNavigationService.Object));
        }

        [TestCaseSource("equalityTestCases")]
        public void EqualityTest(string name1, string name2, bool expectedResult)
        {
            var navigationService = new Mock<INavigationService>();
            navigationService.Setup(s => s.IsPositionWithinBoundaries(It.IsAny<RobotPosition>())).Returns(true);

            var position1 = new RobotPosition { Heading = Heading.East, Location = new Point(1,1) };
            var position2 = new RobotPosition { Heading = Heading.West, Location = new Point(1,1123) };

            var robot1 = new Robot(name1, position1, navigationService.Object);
            var robot2 = new Robot(name2, position2, navigationService.Object);

            Assert.That(Equals(robot1, robot2), Is.EqualTo(expectedResult));
        }

        static object[] equalityTestCases = new object[]
        {
            new object[] {"Name1", "Name1", true},
            new object[] {"Name1", "Name2", false},
            new object[] {"B", "B", true},
            new object[] {"B", "b", false},
        };

        static object[] moveTestCases = new object[]
        {
            new object[]
            {
                new Size(5,5),
                new RobotPosition{ Location = new Point(1, 2), Heading = Heading.North },
                new List<Action<IRobot>>
                {
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                },
                new RobotPosition {Location = new Point(1,3), Heading = Heading.North }
            },

            new object[]
            {
                new Size(5,5),
                new RobotPosition{ Location = new Point(3, 3), Heading = Heading.East },
                new List<Action<IRobot>>
                {
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.MoveForward),
                },
                new RobotPosition {Location = new Point(5,1), Heading = Heading.East }
            },

            // test with out of max bound
            new object[]
            {
                new Size(2,2),
                new RobotPosition{ Location = new Point(1, 2), Heading = Heading.North },
                new List<Action<IRobot>>
                {
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                },
                new RobotPosition {Location = new Point(1,2), Heading = Heading.North }
            },

            // test with out of min bound
            new object[]
            {
                new Size(3,3),
                new RobotPosition{ Location = new Point(2, 0), Heading = Heading.North},
                new List<Action<IRobot>>
                {
                    r => r.Move(RobotCommand.TurnLeft),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.TurnRight),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                    r => r.Move(RobotCommand.MoveForward),
                },
                new RobotPosition {Location = new Point(0, 0), Heading = Heading.South }
            }
        };

        static object[] outOfBoundTestCases = new object[]
        {
            new Point(1,4),
            new Point(13,1),
            new Point(0,1),
            new Point(0,-1),
            new Point(-100,-1),
        };
    }
}
