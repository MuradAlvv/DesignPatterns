namespace DesignPatterns.Command;

public class Editor
{
    private readonly InputHandler _inputHandler;
    private readonly Stack<IReversibleCommand> _commands;
    private readonly List<ISelectable> _itemsToSelect;

    public Editor(InputHandler inputHandler)
    {
        _inputHandler = inputHandler;
        _commands = new Stack<IReversibleCommand>();
        _itemsToSelect = new List<ISelectable>
        {
            new UiElement(),
            new UiElement(),
            new UiElement()
        };
    }

    public void Select()
    {
        ISelectable compositeSelectable = new CompositeSelectable(_itemsToSelect);
        IReversibleCommand command = new SelectCommand(compositeSelectable);
        _inputHandler.ExecuteCommand(command);
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count > 0)
        {
            IReversibleCommand command = _commands.Peek();
            _inputHandler.UndoCommand(command);
        }
    }

    public void Redo()
    {
        if (_commands.Count > 0)
        {
            ICommand command = _commands.Peek();
            _inputHandler.ExecuteCommand(command);
        }
    }
}
