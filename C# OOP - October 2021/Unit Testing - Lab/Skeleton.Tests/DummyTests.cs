using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void LosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(0), "Dummy doesn't looses health");
        }
        [Test]
        public void AttackDeadDummy()
        {
            Dummy dummy = new Dummy(0, 10);
            Axe axe = new Axe(10, 10);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);
            int xp = dummy.GiveExperience();
            Assert.That(xp, Is.EqualTo(10), "Dead dummy doesn't give XP");
        }
        [Test]
        public void AliveDummyCanNotGiveXP()
        {
            Dummy dummy = new Dummy(20, 10);
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}