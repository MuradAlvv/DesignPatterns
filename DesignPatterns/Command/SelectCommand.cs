namespace DesignPatterns.Command;

public class SelectCommand : IReversibleCommand
{
    private readonly ISelectable _selectable;

    public SelectCommand(ISelectable selectable)
    {
        _selectable = selectable;
    }

    public void Execute()
    {
        _selectable.Select();
    }

    public void Undo()
    {
        _selectable.Unselect();
    }
}
