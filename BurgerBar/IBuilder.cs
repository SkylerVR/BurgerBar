public interface IBuilder
{
    void Bun();
    void Salad();
    void Cheese(string cheese);
    void PickledCucumber(string cucumber);
    void Meat(string meat);
    void Sauce(string sauce);
    Burger GetBurger();
}