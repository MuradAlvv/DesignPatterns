namespace DesignPatterns.Prototype;

public abstract class Enemy
{
    public int Health { get; set; }
    public int Damage { get; set; }

    public abstract Enemy Clone();
}
