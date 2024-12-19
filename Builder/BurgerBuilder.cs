public interface IBurgerBuilder
{
    void AddBun(string type);
    void AddPatty(string type);
    void AddSauce(string type);
    void AddTopping(string topping);

    Burger GetBurger();
}

public class CustomBurgerBuilder : IBurgerBuilder
{
    Burger _burger = new();

    public void AddBun(string type)
    {
        _burger.AddIngredient($"Булочка: {type}");
    }
    public void AddPatty(string type)
    {
        _burger.AddIngredient($"Котлета: {type}");
    }
    public void AddSauce(string type)
    {
        _burger.AddIngredient(type);
    }
    public void AddTopping(string topping)
    {
        _burger.AddIngredient(topping);
    }

    public Burger GetBurger()
    {
        return _burger;
    }
}