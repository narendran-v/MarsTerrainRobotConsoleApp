using RobotClass = Codec.MarsTerrain.Robot.Core.Classes.Robot;
using Codec.MarsTerrain.Robot.Core.Classes;

namespace Codec.MarsTerrain.Robot.Tests
{
    [TestFixture]
    class RobotTests
    {
        [Test]
        public void RobotNavigateOnMarsSuccess()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new Plateau("5x5");
            var Compass = new Compass();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, Compass);
            var robot = new RobotClass("FFRFLFLF", currentPosition, positionNavigator);

            //Act
            robot.Navigate();
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreEqual("1,4,West", result);
        }

        [Test]
        public void RobotNavigateOnMarsFailure()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new Plateau("5x5");
            var Compass = new Compass();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, Compass);
            var robot = new RobotClass("FFF", currentPosition, positionNavigator);

            //Act
            robot.Navigate();
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreNotEqual("1,4,West", result);
        }

        [Test]
        public void RobotAlwaysStartAtX1Y1FacingNorthSuccess()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new Plateau("5x5");
            var Compass = new Compass();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, Compass);
            var robot = new RobotClass("FFFFFFFF", currentPosition, positionNavigator);

            //Act            
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreEqual("1,1,North", result);
        }

        [Test]
        public void IfRobotReachesLimitsCommandBeIgnoredSuccess()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new Plateau("5x5");
            var Compass = new Compass();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, Compass);
            var robot = new RobotClass("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", currentPosition, positionNavigator);

            //Act       
            robot.Navigate();
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreEqual("1,5,North", result);
        }


    }
}