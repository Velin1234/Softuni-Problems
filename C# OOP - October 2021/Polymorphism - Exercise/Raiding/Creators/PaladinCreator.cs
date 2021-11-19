namespace Raiding
{
    internal class PaladinCreator : HeroCreator
    {
        private string heroName;

        public PaladinCreator(string heroName)
        {
            this.heroName = heroName;
        }

        public override BaseHero GetHero()
        {
            return new Paladin(heroName);   
        }
    }
}