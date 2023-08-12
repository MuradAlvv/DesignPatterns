namespace DesignPatterns.Command;

public class InputHandler
{
    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
    }

    public void UndoCommand(IReversibleCommand command)
    {
        command.Undo();
    }
}
