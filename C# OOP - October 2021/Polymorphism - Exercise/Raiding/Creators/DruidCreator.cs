namespace Raiding
{
    internal class DruidCreator : HeroCreator
    {
        private string heroName;

        public DruidCreator(string heroName)
        {
            this.heroName = heroName;
        }

        public override BaseHero GetHero()
        {
            return new Druid(heroName);
        }
    }
}