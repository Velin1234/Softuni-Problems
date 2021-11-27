using NUnit.Framework;
using System;
using System.Linq;

namespace FightingArena.Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldInitializeAllValues()
        {
            Arena arena = new Arena();

            Assert.IsNotNull(arena.Warriors);
        }
        
        [Test]
        public void EnrollMethodShouldAddWarriorIfDoesntExists()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Velin", 50, 80);

            arena.Enroll(warrior);

            Assert.AreEqual(1, arena.Count);
            bool warriorExist = arena.Warriors.Any(x => x.Name == warrior.Name);
            Assert.True(warriorExist);
        }
        
        [Test]
        public void EnrollMethodShouldThrowExceptionForDuplicateWarrior()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Velin", 50, 80);
            Warrior warrior2 = new Warrior("Velin", 50, 80);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(()=>arena.Enroll(warrior2));
        }
        
        [Test]
        public void FightMethodShouldThrowExceptionFroInvalidWarriors()
        {
            Arena arena = new Arena();
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Kiro", "Stoyqn"));
        }
        [Test]
        [TestCase("Kiro")]
        public void FightMethodShouldThrowExceptionFroInvalidAttackerOrDefender(string warriorName)
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior(warriorName, 50, 50);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Kiro", warriorName));
            Assert.Throws<InvalidOperationException>(() => arena.Fight(warriorName, "Stoyqn"));
        }
        
        [Test]
        public void FightShouldReduceHP()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("Stoyan", 100, 50);
            Warrior defender = new Warrior("Kiro", 50, 100);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight("Stoyan", "Kiro");

            Warrior warriorAttacker = arena.Warriors.FirstOrDefault(x => x.Name == "Stoyan");
            Warrior warriorDefender = arena.Warriors.FirstOrDefault(x => x.Name == "Kiro");

            Assert.AreEqual(0, warriorAttacker.HP);
            Assert.AreEqual(0, warriorDefender.HP);
        }
    }
}
