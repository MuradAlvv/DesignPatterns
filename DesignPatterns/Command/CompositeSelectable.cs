namespace DesignPatterns.Command;

public class CompositeSelectable : ISelectable
{
    private readonly List<ISelectable> _selectables;

    public CompositeSelectable(List<ISelectable> selectables)
    {
        _selectables = selectables;
    }

    public void Select()
    {
        _selectables.ForEach(selectable => selectable.Select());
    }

    public void Unselect()
    {
        _selectables.ForEach(selectable => selectable.Unselect());
    }

    public void Add(IEnumerable<ISelectable> selectables)
    {
        _selectables.AddRange(selectables);
    }

    public void Add(ISelectable selectable)
    {
        _selectables.Add(selectable);
    }
}
