public class CustomBurgerParams
{
    public string Cheese { get; }
    public string Meat { get; }
    public string Cucumber { get; }
    public string Sauce { get; }

    public CustomBurgerParams(string cheese, string meat, string cucumber, string sauce)
    {
        Cheese = cheese;
        Meat = meat;
        Cucumber = cucumber;
        Sauce = sauce;
    }
}