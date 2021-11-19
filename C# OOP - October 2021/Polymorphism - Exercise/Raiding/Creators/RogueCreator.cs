namespace Raiding
{
    internal class RogueCreator : HeroCreator
    {
        private string heroName;

        public RogueCreator(string heroName)
        {
            this.heroName = heroName;
        }

        public override BaseHero GetHero()
        {
            return new Rogue(heroName);
        }
    }
}