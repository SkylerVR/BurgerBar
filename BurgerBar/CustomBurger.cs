public class CustomBurger : IBuilder
{
    private Burger burgers;
    private CustomBurgerParams customParams;

    public CustomBurger(CustomBurgerParams customParams)
    {
        this.customParams = customParams;
        burgers = new Burger();
    }

    public void Bun()
    {
        burgers.AddBurger("ფუნთუშა");
    }

    public void Salad()
    {
        burgers.AddBurger("სალათის ფურცელი");
    }

    public void Cheese(string cheese)
    {
        burgers.AddBurger(cheese);
    }

    public void Meat(string meat)
    {
        burgers.AddBurger(meat);
    }

    public void PickledCucumber(string cucumber)
    {
        burgers.AddBurger(cucumber);
    }

    public void Sauce(string sauce)
    {
        burgers.AddBurger(sauce);
    }

    public Burger GetBurger()
    {
        return burgers;
    }
}