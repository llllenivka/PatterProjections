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
            Console.WriteLine("Добавить топпинг (да/нет):");

            string ? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input) || (input != "да" && input != "нет"))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз\n");
                continue;
            }

            if (input == "нет") break;

            director = ChooseTopping(director);
        }

        var burger = burgerBuilder.GetBurger();
        return burger;
    }

    public static Director ChooseBurger(Director director)
    {
        while(true)
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
                    return director;
                case "2":
                    director.MakeVeganBurger();
                    return director;
                case "3":
                    var ingredients = ChooseIngredients();
                    director.MakeBurger(ingredients.Item1, ingredients.Item2, ingredients.Item3);
                    return director;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз\n");
                    break;
            }
        }

        return director;
    }

    public static (string, string, string) ChooseIngredients()
    {
        string ? bun, patty, sauce;
        while(true)
        {
            Console.WriteLine("Выберите булочку (белая, цельнозерновая, без глютена): ");
            bun = Console.ReadLine();
            if(bun == "белая"|| bun == "цельнозерновая" || bun == "без глютена") break;
            Console.WriteLine("Такой булочки нет. Поробуйте еще раз\n");
        }

        while(true)
        {
            Console.WriteLine("Выберите котлету (говяжья, куриная, растительная): ");
            patty = Console.ReadLine();
            if(patty == "говяжья"|| patty == "куриная" || patty == "растительная") break;
            Console.WriteLine("Такой котлеты нет. Поробуйте еще раз\n");
        }

        while(true)
        {
            Console.WriteLine("Выберите соус (майонез, кетчуп, барбекю): ");
            sauce = Console.ReadLine();
            if(sauce == "майонез"|| sauce == "кетчуп" || sauce == "барбекю") break;
            Console.WriteLine("Такого соуса нет. Поробуйте еще раз\n");
        }
        return (bun, patty, sauce);

    }

    public static Director ChooseTopping(Director director)
    {
        while(true)
        {
            Console.WriteLine("Выбирите топпинг (сыр, лук, огурцы): ");

            string ? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input) || (input != "сыр" && input != "лук" && input != "огурцы"))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз\n");
            } 
            else 
            {
                director.AddTopping(input);
                break;
            }
        }
        return director;
    }


}