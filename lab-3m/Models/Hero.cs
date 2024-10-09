public abstract class Hero
{
    public abstract string GetDescription();
    public abstract int GetPower();
}

public class Warrior : Hero
{
    public override string GetDescription() => "Warrior";
    public override int GetPower() => 100;
}

public class Mage : Hero
{
    public override string GetDescription() => "Mage";
    public override int GetPower() => 80;
}

public class Paladin : Hero
{
    public override string GetDescription() => "Paladin";
    public override int GetPower() => 90;
}
public abstract class HeroDecorator : Hero
{
    protected Hero _hero;
    public HeroDecorator(Hero hero)
    {
        _hero = hero;
    }

    public override string GetDescription() => _hero.GetDescription();
    public override int GetPower() => _hero.GetPower();
}

public class Armor : HeroDecorator
{
    public Armor(Hero hero) : base(hero) { }

    public override string GetDescription() => base.GetDescription() + ", with Armor";
    public override int GetPower() => base.GetPower() + 20;
}

public class Weapon : HeroDecorator
{
    public Weapon(Hero hero) : base(hero) { }

    public override string GetDescription() => base.GetDescription() + ", with Weapon";
    public override int GetPower() => base.GetPower() + 30;
}
