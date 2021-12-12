namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {

        [Test]
        public void PresentConstructorIsNotNull()
        {
            Assert.IsNotNull(new Present("Name", 22.3));
        }

        [Test]
        public void BagConstructorIsNotNull()
        {
            Assert.IsNotNull(new Bag());
        }

        [Test]
        public void CreateShouldThrowArgumentNullException()
        {
            Present present = null;
            Bag bag = new Bag();
            Assert.Throws<ArgumentNullException>(() => bag.Create(present));
        }

        [Test]
        public void CreateShouldThrowInvalidOperationExceptionIfContainsPresent()
        {
            var present = new Present("Name", 10);
            Bag bag = new Bag();
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void CreateSuccess()
        {
            var present = new Present("Name", 10);
            Bag bag = new Bag();
            bag.Create(present);
            Assert.AreEqual(present, bag.GetPresent("Name"));
        }

        [Test]
        public void RemoveSuccess()
        {
            var present = new Present("Name", 10);
            Bag bag = new Bag();
            bag.Create(present);
            Assert.IsTrue(bag.Remove(present));
        }

        [Test]
        public void RemoveFailure()
        {
            var present = new Present("Name", 10);
            Bag bag = new Bag();
            Assert.IsFalse(bag.Remove(present));
        }

        [Test]
        public void GetPresentWithLeastMagicThrowsInvalidOperationExceptionWhenEmpty()
        {
            Bag bag = new Bag();
            Assert.Throws<InvalidOperationException>(() => bag.GetPresentWithLeastMagic());
        }

        [Test]
        public void GetPresentWithLeastMagicSuccess()
        {
            var present = new Present("Name", 10);
            var present2 = new Present("Name2", 5);
            var present3 = new Present("Name3", 1);
            Bag bag = new Bag();
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            Assert.AreEqual(present3, bag.GetPresentWithLeastMagic());
        }

        [Test]
        public void GetPresentReturnsNull()
        {
            Bag bag = new Bag();
            Assert.IsNull(bag.GetPresent("Name"));
        }

        [Test]
        public void GetPresentReturnsPresent()
        {
            var present = new Present("Name", 10);
            Bag bag = new Bag();
            bag.Create(present);
            Assert.AreEqual(present, bag.GetPresent("Name"));
        }

        [Test]
        public void GetPresentsReturnsPresents()
        {
            Present present = new Present("Name", 10);
            Bag bag = new Bag();
            bag.Create(present);
            IReadOnlyCollection<Present> presents = bag.GetPresents();
            Assert.AreEqual(1, presents.Count);
        }

        [Test]
        public void GetPresentsReturnsNull()
        {
            Bag bag = new Bag();
            Assert.IsEmpty(bag.GetPresents());
        }
    }
}
