namespace DesignPatterns.State;

public class Package
{
    private IPackageState _packageState;

    public IPackageState PackageState
    {
        get => _packageState;
        set => _packageState = value;
    }

    public Package()
    {
        _packageState = new OrderedPackageState();
    }

    public void NextState()
    {
        _packageState.SetNext(this);
    }

    public void PrintStatus()
    {
        Console.WriteLine(_packageState.GetStatus());
    }
}