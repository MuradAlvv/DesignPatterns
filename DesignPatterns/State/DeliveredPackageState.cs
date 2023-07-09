namespace DesignPatterns.State;

public class DeliveredPackageState : IPackageState
{
    public void SetNext(Package package)
    {
        package.PackageState = new ReceivedPackageState();
    }

    public string GetStatus()
    {
        return "delivered";
    }
}