namespace DesignPatterns.State;

public interface IPackageState
{
    void SetNext(Package package);
    string GetStatus();
}