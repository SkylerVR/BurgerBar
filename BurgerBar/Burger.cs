public class Burger
{
    private LinkedList<string> burgers;

    public Burger()
    {
        burgers = new LinkedList<string>();
    }

    public void AddBurger(string burgerPart)
    {
        burgers.AddLast(burgerPart);
    }

    public void Show()
    {
        int totalItems = burgers.Count;
        int currentIndex = 1;

        foreach (var burger in burgers)
        {
            Console.Write(burger);

            // Append comma if it's not the last item
            if (currentIndex < totalItems)
            {
                Console.Write(",");
            }
            currentIndex++;
        }
    }
}