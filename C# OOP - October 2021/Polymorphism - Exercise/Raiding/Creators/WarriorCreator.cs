namespace Raiding
{
    internal class WarriorCreator : HeroCreator
    {
        private string heroName;

        public WarriorCreator(string heroName)
        {
            this.heroName = heroName;
        }

        public override BaseHero GetHero()
        {
            return new Warrior(heroName);
        }
    }
}