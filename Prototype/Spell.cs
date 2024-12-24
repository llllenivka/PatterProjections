public interface ISpellPrototype
{
    ISpellPrototype Clone();
    void UseSpell ();
}

public class FireSpell : ISpellPrototype
{
    public string Name { get; set; } = "Огненный шар";
    public int Damage { get; set; } = 60;
    public int ManaCost { get; set; } = 45;
    public ISpellPrototype Clone()
    {
        return (ISpellPrototype)this.MemberwiseClone();
    }
    public void UseSpell()
    {
        Console.WriteLine($"Использован {Name}. Нанесено урона: {Damage}. Использовано маны: {ManaCost} ");
    }
}

public class IceSpell : ISpellPrototype
{
    public string Name { get; set; } = "Ледяная стрела";
    public int Damage { get; set; } = 20;
    public int ManaCost { get; set; } = 15;
    public int SlowEffect { get; set; } = 10;
    public ISpellPrototype Clone()
    {
        return (ISpellPrototype)this.MemberwiseClone();
    }
    public void UseSpell()
    {
        Console.WriteLine($"Использован {Name}. ",
                          $"Нанесено урона: {Damage}. ",
                          $"Использовано маны: {ManaCost}. ",
                          $"Замедление на {SlowEffect}");
    }
}

public class HealSpell : ISpellPrototype
{
    public string Name { get; set; } = "Лечение";
    public int HealPower { get; set; } = 50;
    public int ManaCost { get; set; } = 35;
    public ISpellPrototype Clone()
    {
        return (ISpellPrototype)this.MemberwiseClone();
    }
        public void UseSpell()
    {
        Console.WriteLine($"Использован {Name}. ",
                          $"Лечение: +{HealPower}. ",
                          $"Использовано маны: {ManaCost}. ");
    }
}