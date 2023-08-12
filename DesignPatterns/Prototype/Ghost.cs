namespace DesignPatterns.Prototype;

public class Ghost : Enemy
{
    public override Enemy Clone()
    {
        Ghost ghost = new Ghost();
        ghost.Health = Health;
        ghost.Damage = Damage;
        return ghost;
    }
}
