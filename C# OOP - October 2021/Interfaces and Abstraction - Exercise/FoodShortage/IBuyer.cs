namespace FoodShortage
{
    public interface IBuyer
    {
        string Name { get; }
        int BuyFood();
    }
}