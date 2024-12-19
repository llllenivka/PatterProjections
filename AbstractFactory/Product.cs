public interface IBreakfast 
{
    void Cook();
}

public interface ILunch
{
    void Cook();
}

public class ItalianBreakfast : IBreakfast
{
    public void Cook()
    {
        Console.WriteLine("Приготовление завтрака: Капучино");
    }
}

public class JapaneseBreakfast : IBreakfast
{
    public void Cook()
    {
        Console.WriteLine("Приготовление завтрака: Мисо-суп");
    }
}

public class FrenchBreakfast : IBreakfast
{
    public void Cook()
    {
        Console.WriteLine("Приготовление завтрака: Круассан");
    }
}

public class ItalianLunch : ILunch
{
    public void Cook()
    {
        Console.WriteLine("Приготовление обеда: Паста");
    }
}

public class JapaneseLunch : ILunch
{
    public void Cook()
    {
        Console.WriteLine("Приготовление обеда: Суши");
    }
}

public class FrenchLunch : ILunch
{
    public void Cook()
    {
        Console.WriteLine("Приготовление обеда: Рататуй");
    }
}