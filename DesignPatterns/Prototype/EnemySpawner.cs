namespace DesignPatterns.Prototype;

public class EnemySpawner
{
    private Enemy _prototype;

    public EnemySpawner(Enemy prototype)
    {
        _prototype = prototype;
    }

    public Enemy Spawn()
    {
        return _prototype.Clone();
    }
}
