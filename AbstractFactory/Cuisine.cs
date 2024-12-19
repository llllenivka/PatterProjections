public interface ICuisineFactory
{
    IBreakfast CreateBreakfast();
    ILunch CreateLunch();
}

public class ItalianCuisineFactory : ICuisineFactory
{
    public IBreakfast CreateBreakfast()
    {
        return new ItalianBreakfast();
    }

    public ILunch CreateLunch()
    {
        return new ItalianLunch();
    }
}

public class JapaneseCuisineFactory : ICuisineFactory
{
    public IBreakfast CreateBreakfast()
    {
        return new JapaneseBreakfast();
    }

    public ILunch CreateLunch()
    {
        return new JapaneseLunch();
    }
}

public class FrenchCuisineFactory : ICuisineFactory
{
    public IBreakfast CreateBreakfast()
    {
        return new FrenchBreakfast();
    }

    public ILunch CreateLunch()
    {
        return new FrenchLunch();
    }
}