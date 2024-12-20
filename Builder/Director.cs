class Director
{
    private IBurgerBuilder _burgerBuilder;

    public Director(IBurgerBuilder burgerBuilder)
    {
        _burgerBuilder = burgerBuilder;
    }

    public void MakeBurger(string bun, string patty, string sauce)
    {
        _burgerBuilder.AddBun(bun);
        _burgerBuilder.AddPatty(patty);
        _burgerBuilder.AddSauce(sauce);
    }

    public void MakeClassicBurger()
    {
        MakeBurger("белая", "говяжья", "кетчуп");
    }

    public void MakeVeganBurger()
    {
        MakeBurger("цельнозерновая", "растительная", "барбекью");
    }

    public void AddTopping(string topping)
    {
        _burgerBuilder.AddTopping(topping);
    }
}