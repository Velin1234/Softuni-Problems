namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int DefaultWarriorPower = 100;

        public Warrior(string name) : base(name, DefaultWarriorPower)
        {
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"hit for {this.Power} damage";
        }
    }
}