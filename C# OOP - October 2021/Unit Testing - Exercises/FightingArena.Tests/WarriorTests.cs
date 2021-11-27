using NUnit.Framework;
using System;

namespace FightingArena.Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Stoyan", 50, 70)]
        public void ConstructorShouldSetEverythingIfDataIsValid(string name, int damage, int health)
        {
            Warrior warrior = new Warrior(name, damage, health);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(health, warrior.HP);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ConstructorShouldThrowArgumentExceptionForInvalidName(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 10, 20));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ConstructorShouldThrowArgumentExceptionForInvalidDamage(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Velin", damage, 20));
        }

        [TestCase(-1)]
        public void ConstructorShouldThrowArgumentExceptionForInvalidHP(int HP)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Velin", 10, HP));
        }

        [TestCase("Velin", 50, 30, "Koce", 50, 50)]
        [TestCase("Velin", 50, 50, "Koce", 50, 30)]
        public void AttackMethodShouldThrowExceptionWhenHPIsBelowOrEqual30(string name, int damage, int health,
            string enemyName, int enemyDamage, int enemyHealth)
        {
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemy = new Warrior(enemyName, enemyDamage, enemyHealth);

            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemy));
        }

        [TestCase("Velin", 20, 40, "Koce", 50, 50)]
        public void AttackMethodShouldThrowExceptionWhenDamageIsLargerThanHP(string name, int damage, int health,
            string enemyName, int enemyDamage, int enemyHealth)
        {
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemy = new Warrior(enemyName, enemyDamage, enemyHealth);

            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemy));
        }

        [TestCase("Velin", 100, 200, "Koce", 100, 200)]
        [TestCase("Velin", 100, 200, "Koce", 100, 100)]
        public void AttackMethodShouldReduceHpForWarriorAndEnemyWarrior(string name, int damage, int health,
            string enemyName, int enemyDamage, int enemyHealth)
        {
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemy = new Warrior(enemyName, enemyDamage, enemyHealth);


            int expectedHealthMyWarrior = myWarrior.HP - enemy.Damage;
            int expectedHealthEnemy = enemy.HP - myWarrior.Damage;
            myWarrior.Attack(enemy);

            if (enemy.HP == 0)
            {
                expectedHealthEnemy = 0;
            }

            Assert.AreEqual(expectedHealthEnemy, enemy.HP);
            Assert.AreEqual(expectedHealthMyWarrior, myWarrior.HP);
        }
    }
}