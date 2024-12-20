class Program
{
    public static void Main()
    {
        Burger burger = GetBurger();
        burger.ShowIngredients();
    }

    public static Burger GetBurger()
    {
        IBurgerBuilder burgerBuilder = new CustomBurgerBuilder();
        Director director = new(burgerBuilder);
        director = ChooseBurger(director);

        while(true)
        {
            Console.WriteLine("Добавить топпинг:");
            Console.WriteLine("1 - да");
            Console.WriteLine("2 - нет");

            string ? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input) || (input != "1" && input != "2"))
            {
                continue;
            }
            else if(input == "1")
            {
                director = ChooseTopping(director);
            }

            break;
        }

        var burger = burgerBuilder.GetBurger();
        return burger;
    }

    public static Director ChooseBurger(Director director)
    {
        Console.WriteLine("Выбирите бургер:");
        Console.WriteLine("1 - Классический бургер");
        Console.WriteLine("2 - Вегансикй бургер");
        Console.WriteLine("3 - Создать бургер вручную");

        string ? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                director.MakeClassicBurger();
                break;
            case "2":
                director.MakeVeganBurger();
                break;
            case "3":
                // director.MakeSBurger();
                break;
            default:
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз");
                director = ChooseBurger(director);
                break;
        }

        return director;
    }пше 

    public static Director ChooseTopping(Director director)
    {
        Console.WriteLine("Выбирите топпинг:");
        Console.WriteLine("1 - сыр");
        Console.WriteLine("2 - лук");
        Console.WriteLine("3 - огурцы");

        string ? input = Console.ReadLine();
        if(string.IsNullOrEmpty(input) || (input != "1" && input != "2" && input != "3"))
        {
            Console.WriteLine("Некорруктный ввод. Попробуйте еще раз");
            return ChooseTopping(director);
        } 
        
        switch(input)
        {
            case "1":
                director.AddTopping("сыр");
                break;
            case "2":
                director.AddTopping("лук");
                break;
            case "3":
                director.AddTopping("огурцы");
                break;
        }

        return director;
    }
}