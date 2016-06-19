using NUnit.Framework;
using RobotWars.Navigation;
using System.Drawing;

namespace RobotWars.Console.Test
{
    [TestFixture]
    class RobotPositionParserTest
    {
        [TestCaseSource("parseTestCases")]
        public void ParseTest(string input, bool successful, RobotPosition expectedPosition)
        {
            if (successful)
            {
                var position = RobotPositionParser.Parse(input);
                Assert.That(position, Is.EqualTo(expectedPosition));
            }
            else
            {
                Assert.Throws<System.ArgumentException>(() => RobotPositionParser.Parse(input));
            }
        }

        static object[] parseTestCases = new object[]
        {
            new object[] 
            {
                "1 2 E",
                true,
                new RobotPosition { Heading = Heading.East, Location = new Point(1, 2) }
            },
            new object[]
            {
                "1 2",
                false,
                default(RobotPosition)
            },
            new object[]
            {
                "",
                false,
                default(RobotPosition)
            },
            new object[]
            {
                "1 2 T",
                false,
                default(RobotPosition)
            }
        };
    }
}
