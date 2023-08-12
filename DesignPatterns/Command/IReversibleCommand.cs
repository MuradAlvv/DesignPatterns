namespace DesignPatterns.Command;

public interface IReversibleCommand: ICommand
{
    void Undo();
}
