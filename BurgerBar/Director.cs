public class Director
{
    private IBuilder builder;

    public Burger MakeBurger(CustomBurgerParams customParams)
    {
        builder = new CustomBurger(customParams);
        builder.Bun();
        builder.Salad();
        builder.Cheese(customParams.Cheese);
        builder.Sauce(customParams.Sauce);
        builder.Meat(customParams.Meat);
        builder.PickledCucumber(customParams.Cucumber);
        return builder.GetBurger();
    }
}