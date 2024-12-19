class Director
{
    private IBurgerBuilder _burgerBuilder;

    public Director(IBurgerBuilder burgerBuilder)
    {
        _burgerBuilder = burgerBuilder;
    }

    public void MakeClassic()
    {
        _burgerBuilder.AddBun("белая");
    }
}