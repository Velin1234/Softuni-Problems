using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    [TestFixture]
    public class GymsTests
    {
        [Test]
        public void SuccessAthleteConstructor()
        {
            Athlete athlete = new Athlete("Ivan");
            Assert.IsNotNull(athlete);
            Assert.IsFalse(athlete.IsInjured);
        }

        [Test]
        public void SuccessGymConstructor()
        {
            Gym gym = new Gym("Gym", 10);
            Assert.IsNotNull(gym);
        }

        [TestCase(null)]
        [TestCase("")]
        public void ThrowArgumentNullExceptionNameGym(string input)
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(input, 10));
        }

        [TestCase(-1)]
        public void ThrowArgumentExceptionCapacityGym(int input)
        {
            Assert.Throws<ArgumentException>(() => new Gym("Gym", input));
        }

        [Test]
        public void CountReturnsAthleteCount()
        {
            Gym gym = new Gym("Name", 10);
            gym.AddAthlete(new Athlete("John"));
            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void AddAthleteThrowsInvalidOperationIfGymIsFull()
        {
            Gym gym = new Gym("Name", 1);
            gym.AddAthlete(new Athlete("Ivan"));
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(new Athlete("peter")));
        }
    
        [Test]
        public void SuccessAddAthlete()
        {
            Gym gym = new Gym("Name", 10);
            gym.AddAthlete(new Athlete("John"));
            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void RemoveAthleteThrowsInvalidOperationExceptionWhenNull()
        {
            Gym gym = new Gym("Name",2);
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Peter"));
        }
    
        [Test]
        public void SuccessRemoveAthlete()
        {
            Gym gym = new Gym("Name", 10);
            gym.AddAthlete(new Athlete("Peter"));
            gym.RemoveAthlete("Peter");
            Assert.AreEqual(0, gym.Count);
        }

        [Test]
        public void InjureAthleteThrowsInvalidOperationException()
        {
            Gym gym = new Gym("name", 1);
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Ivan"));
        }
    
        [Test]
        public void SuccessInjureAthlete()
        {
            Gym gym = new Gym("name", 1);
            gym.AddAthlete(new Athlete("Peter"));
            Assert.IsTrue(gym.InjureAthlete("Peter").IsInjured);
        }
        
        [Test]
        public void ReportOnlyPrintsGymWhenEmpty()
        {
            Gym gym = new Gym("Name",1);
            string expected = $"Active athletes at {gym.Name}: ";
            Assert.AreEqual(expected, gym.Report());
        }
        
        [Test]
        public void ReportPrintsAllAthletes()
        {
            Gym gym = new Gym("Name", 3);
            gym.AddAthlete(new Athlete("Peter"));
            gym.AddAthlete(new Athlete("Ivan"));
            gym.AddAthlete(new Athlete("George"));
            string expected = $"Active athletes at {gym.Name}: Peter, Ivan, George";
        }
    }
}
