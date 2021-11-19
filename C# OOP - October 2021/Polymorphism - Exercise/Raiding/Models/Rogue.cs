namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int DefaultRoguePower = 80;
        public Rogue(string name) : base(name,DefaultRoguePower)
        {
        }

        public override string CastAbility()
        {
            return base.CastAbility()+ $"hit for {this.Power} damage";
        }
    }
}