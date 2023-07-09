namespace DesignPatterns.State;

public class OrderedPackageState : IPackageState
{
    public void SetNext(Package package)
    {
        package.PackageState = new DeliveredPackageState();
    }

    public string GetStatus()
    {
        return "ordered";
    }
}