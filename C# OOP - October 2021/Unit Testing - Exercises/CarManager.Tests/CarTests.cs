using NUnit.Framework;
using System;

namespace CarManager
{
    [TestFixture]
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("Mercedes", "G-Class", 7.5, 8);
        }
        [Test]
        public void ConstructorShouldCreateCar()
        {
            bool assertCondition = car.Make == "Mercedes" && car.Model == "G-Class"
                && car.FuelConsumption == 7.5 && car.FuelCapacity == 8 && car.FuelAmount == 0;

            Assert.AreEqual(true, assertCondition);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void MakeAndModelShouldNotBeNullOrEmpty(string value)
        {
            Assert.Throws<ArgumentException>(() => new Car(value, "G-Class", 7.5, 8));
            Assert.Throws<ArgumentException>(() => new Car("Mercedes", value, 7.5, 8));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        public void FuelConsumptionAndFuelCapacityShouldNotBeNegativeOrZero(double value)
        {
            Assert.Throws<ArgumentException>(() => new Car("Mercedes", "G-Class", 7.5, value));
            Assert.Throws<ArgumentException>(() => new Car("Mercedes", "G-Class", value, 8));
        }


        [Test]
        [TestCase(8.5)]
        public void RefuelShouldAddFuel(double fuel)
        {
            car.Refuel(fuel);
            if (fuel > car.FuelCapacity)
            {
                fuel = car.FuelCapacity;
            }
            Assert.AreEqual(fuel, car.FuelAmount);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        public void FuelForRefuelShouldNotBeZeroOrNegative(double fuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuel));
        }

        [Test]
        [TestCase(100)]
        public void DriveShouldDrive(double distance)
        {
            car.Refuel(100);
            double expectedFuel = car.FuelAmount - (distance / 100) * car.FuelConsumption;
            car.Drive(distance);
            Assert.AreEqual(car.FuelAmount, expectedFuel);
        }

        [Test]
        [TestCase(100)]
        public void NotEnoughFuelToDrive(double distance)
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }
    }
}