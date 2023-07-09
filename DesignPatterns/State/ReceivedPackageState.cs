namespace DesignPatterns.State;

public class ReceivedPackageState : IPackageState
{
    public void SetNext(Package package)
    {
        package.PackageState = new ReceivedPackageState();
    }

    public string GetStatus()
    {
        return "received";
    }
}