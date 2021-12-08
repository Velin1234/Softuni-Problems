namespace Robots.Tests
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class RobotsTests
    {
        [Test]
        public void RobotConstructorCreateSuccesfully()
        {
            Robot robot = new Robot("Name", 100);
            Assert.IsNotNull(robot);
            Assert.AreEqual(robot.Name, "Name");
            Assert.AreEqual(robot.MaximumBattery, 100);
            Assert.AreEqual(robot.Battery, robot.MaximumBattery);
        }
        [Test]
        public void RobotManagerConstructorShouldBeCreated()
        {
            RobotManager robotManager = new RobotManager(10);
            Assert.IsNotNull(robotManager);
        }
        
        [Test]
        public void RobotManagerConstructorShouldThrowArgumentExceptionIfCapacityIsLessThanZero()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-1));
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionIfRobotWithSameNameExists()
        {
            var robot = new Robot("Name", 100);
            var robot2 = new Robot("Name", 100);
            var robotManager = new RobotManager(10);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(()=>robotManager.Add(robot2));
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionIfNotEnoughSpaceInRobotManager()
        {
            var robot = new Robot("Name", 100);
            var robot2 = new Robot("Name2", 100);
            var robotManager = new RobotManager(1);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot2));
        }

        [Test]
        public void SuccessfulAddOfRobotToRobotManager()
        {
            var robot = new Robot("Name", 100);
            var robot2 = new Robot("Name2", 100);
            var robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(robot2);
            Assert.AreEqual(robotManager.Count, 2);
        }
        
        [Test]
        public void RemoveMethodShouldThrowInvalidOperationExceptionIfRobotIsNull()
        {
            var robotManger = new RobotManager(10);
            Assert.Throws<InvalidOperationException>(() => robotManger.Remove("Name1"));
        }

        [Test]
        public void SuccessfulRemoveOfRobotInRobotManager()
        {
            RobotManager robotManager = new RobotManager(10);
            robotManager.Add(new Robot("Ivan", 20));
            robotManager.Add(new Robot("Peter", 20));
            int currentCount = robotManager.Count;
            robotManager.Remove("Ivan");
            Assert.AreEqual(robotManager.Count, currentCount-1);
        }
        
        [Test]
        public void WorkMethodShouldThrowInvalidOperationExceptionIfRobotIsNull()
        {
            var robotManger = new RobotManager(10);
            Assert.Throws<InvalidOperationException>(() => robotManger.Work("Name","Work",20));
        }
    
        [Test]
        public void ShouldThrowInvalidOperationExceptionWhenBatteryUsageIsBiggerThanBattery()
        {
            RobotManager robotManager = new RobotManager(10);
            robotManager.Add(new Robot("Peter", 10));
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Peter", "Work", 20));
        }
    
        [Test]
        public void SuccessfulWorkMethod()
        {
            Robot robot = new Robot("Peter", 20);
            RobotManager robotManager = new RobotManager(10);
            robotManager.Add(robot);
            robotManager.Work("Peter", "Work", 10);
            Assert.AreEqual(robot.Battery, 10);
        }

        [Test]
        public void ChargeMethodShouldThrowInvalidOperationExceptionIfRobotIsNull()
        {
            RobotManager robotManager = new RobotManager(10);
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("robot"));
        }

        [Test]
        public void SuccessfulChargeMethod()
        {
            Robot robot = new Robot("Ivo", 20);
            RobotManager robotManager = new RobotManager(10);
            robotManager.Add(robot);
            robotManager.Work("Ivo", "Rabota", 20);
            robotManager.Charge("Ivo");
            Assert.AreEqual(robot.Battery, 20);
        }
    }
}
