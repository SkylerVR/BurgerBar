
namespace BurgerBar
{
    public class Program
    {
public static void Main(string[] args)
        {
            int mode;
            Console.WriteLine("აირჩიეთ მენიუ: 1. მზა ბურგერები 2. დაამზადეთ თავად.");
            mode = int.Parse(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    Console.WriteLine("აირჩიეთ: 1.ჩიზბურგერი, 2.ჰამბურგერი, 3.საფირმო");

                    int burgerParse = int.Parse(Console.ReadLine());
                    if (burgerParse == 1)
                    {
                        CustomBurgerParams customBurgerParams = new CustomBurgerParams(
                            cheese: "მდნარი ყველი",
                            meat: "ხორცი",
                            cucumber: "მჟავე კიტრი",
                            sauce: "ცხარე სოუსი"
                        );
                        Director director = new Director();
                        Burger burger = director.MakeBurger(customBurgerParams);
                        Console.WriteLine("ჩიზბურგერის მენიუ: ");
                        burger.Show();
                    }
                    else if (burgerParse == 2)
                    {
                        CustomBurgerParams customBurgerParams = new CustomBurgerParams(
                            cheese: "",
                            meat: "საქონლის ხორცი",
                            cucumber: "მჟავე კიტრი",
                            sauce: "ტკბილი სოუსი"
                        );
                        Director director = new Director();
                        Burger burger = director.MakeBurger(customBurgerParams);
                        Console.WriteLine("ჰამბურგერის მენიუ:");
                        burger.Show();
                    }
                    else if (burgerParse == 3)
                    {
                        CustomBurgerParams customBurgerParams = new CustomBurgerParams(
                            cheese: "",
                            meat: "ქათმის ხორცი",
                            cucumber: "მჟავე კიტრი",
                            sauce: "საფირმო სოუსი"
                        );
                        Director director = new Director();
                        Burger burger = director.MakeBurger(customBurgerParams);
                        Console.WriteLine("საფირმოს მენიუ: ");
                        burger.Show();
                    }
                    else
                    {
                        Console.WriteLine("არასწორი შეკვეთა");
                    }
                    break;
                case 2:
                    while (true)
                    {
                        string cheese = "";
                        string meat = "";
                        string cucumber = "";
                        string sauce = "";

                        Console.WriteLine("ჰქონდეს მდნარი ყველი?");
                        Console.WriteLine("1. კი");
                        Console.WriteLine("2. არა");
                        int checkCheese = int.Parse(Console.ReadLine());
                        cheese = checkCheese == 1 ? "მდნარი ყველი" : "";

                        Console.WriteLine("ჰქონდეს მჟავე კიტრი?");
                        Console.WriteLine("1. კი");
                        Console.WriteLine("2. არა");
                        int checkCucumber = int.Parse(Console.ReadLine());
                        cucumber = checkCucumber == 1 ? "მჟავე კიტრი" : "";
                        Console.WriteLine("აირჩიეთ ხორცი: 1)ქათმის 2) საქონლის 3)არცერთი");
                        int chooseMeat = int.Parse(Console.ReadLine());
                        if (chooseMeat == 1)
                        {
                            meat = "ქათმის ხორცი";
                        }
                        else if (chooseMeat == 2)
                        {
                            meat = "საქონლის ხორცი";
                        }
                        else
                        {
                            meat = "";
                        }

                        Console.WriteLine("აირჩიეთ სოუსი: 1)ცხარე 2) ტკბილი 3) საფირმო 4)არცერთი");
                        int chooseSauce = int.Parse(Console.ReadLine());
                        if (chooseSauce == 1)
                        {
                            sauce = "ცხარე სოუსი";
                        }
                        else if (chooseSauce == 2)
                        {
                            sauce = "ტკბილი სოუსი";
                        }
                        else if (chooseSauce == 3)
                        {
                            sauce = "საფირმო სოუსი";
                        }
                        else
                        {
                            sauce = "";
                        }
                        CustomBurgerParams customBurgerParams = new CustomBurgerParams(
                            cheese: cheese,
                            meat: meat,
                            cucumber: cucumber,
                            sauce: sauce
                        );
                        Director director = new Director();
                        Burger burger = director.MakeBurger(customBurgerParams);
                        Console.WriteLine("თქვენი შეკვეთა: ");
                        burger.Show();
                        break;
                    }
                    break;
            }
        }
    }
}