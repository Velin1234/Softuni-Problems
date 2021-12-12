using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    HeroRepository heroRepository;
    
    [Test]
    public void SuccessfullHeroConstructor()
    {
        Hero hero = new Hero("Name", 123);
        Assert.IsNotNull(hero);
    }

    [Test]
    public void SuccessfullHeroRepositoryConstructor()
    {
        HeroRepository heroRepository = new HeroRepository();
        Assert.IsNotNull(heroRepository);
    }

    [Test]
    public void CreateMethodThrowsExceptionWhenHeroNull()
    {
        heroRepository = new HeroRepository();
        Hero hero = null;
        Assert.Throws<ArgumentNullException>(() => heroRepository.Create(hero));
    }

    [Test]
    public void CreateMethodThrowsExceptionWhenHeroExists()
    {
        heroRepository = new HeroRepository();
        Hero hero = new Hero("Name", 123);
        heroRepository.Create(hero);
        Assert.Throws<InvalidOperationException>(() => heroRepository.Create(hero));
    }

    [Test]
    public void SuccessfullCreateOfHero()
    {
        heroRepository = new HeroRepository();
        Hero hero = new Hero("Name", 123);
        heroRepository.Create(hero);
        Assert.AreEqual(1, heroRepository.Heroes.Count);
    }

    [TestCase(null)]
    [TestCase(" ")]
    [TestCase("")]
    public void RemoveMethodThrowsArgumentNullException(string input)
    {
        heroRepository = new HeroRepository();
        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(input));
    }

    [Test]
    public void RemoveExistingInRepositoryHero()
    {
        heroRepository = new HeroRepository();
        heroRepository.Create(new Hero("Name", 10));
        Assert.IsTrue(heroRepository.Remove("Name"));
    }

    [Test]
    public void RemoveNotExistingInRepositoryHero()
    {
        heroRepository = new HeroRepository();
        Assert.IsFalse(heroRepository.Remove("Name"));
    }

    [Test]
    public void GetHeroWithHighestLevelReturnsHighestLevelHero()
    {
        Hero hero = new Hero("Name", 100);
        Hero hero1 = new Hero("name", 1);
        heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);

        Assert.AreSame(hero, heroRepository.GetHeroWithHighestLevel());
    }

    [Test]
    public void GetHeroWithHighestLevelReturnsNull()
    {
        heroRepository = new HeroRepository();
        Assert.IsNull(heroRepository.GetHeroWithHighestLevel());
    }
    [Test]
    public void GetHeroReturnsHero()
    {
        heroRepository = new HeroRepository();
        Hero hero = new Hero("Name", 100);
        heroRepository.Create(hero);
        Assert.AreSame(hero, heroRepository.GetHero("Name"));
    }
    [Test]
    public void GetHeroReturnsNull()
    {
        heroRepository = new HeroRepository();
        Assert.IsNull(heroRepository.GetHero("Hero"));
    }
}