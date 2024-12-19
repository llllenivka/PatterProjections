public class Burger
{
    private List<string> _ingredients = new();

    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public void ShowIngredients()
    {
        Console.WriteLine("Ваш бургер состоит из:");
        _ingredients.ForEach(ingredient => Console.WriteLine($"- {ingredient}"));
    }
}