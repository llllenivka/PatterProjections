class Program
{
    public static void Main()
    {
        ICuisineFactory cuisineFactory = ChooseCuisine();

        IBreakfast breakfast = cuisineFactory.CreateBreakfast();
        ILunch lunch = cuisineFactory.CreateLunch();

        breakfast.Cook();
        lunch.Cook();   
    }

    public static ICuisineFactory ChooseCuisine()
    {
        Console.Write("Выберите кухню (1 - Итальянская, 2 - Японская, 3 - Французка): ");
        string ? input = Console.ReadLine();
        ICuisineFactory ? cuisineFactory = input switch
        {
            "1" => new ItalianCuisineFactory(),
            "2" => new JapaneseCuisineFactory(),
            "3" => new FrenchCuisineFactory(),
            _ => null    
        };
        if(cuisineFactory == null){
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз");
            cuisineFactory = ChooseCuisine();
        } 
        return cuisineFactory;
    }
}