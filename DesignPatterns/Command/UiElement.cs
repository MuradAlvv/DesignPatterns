using System.Drawing;

namespace DesignPatterns.Command;

public class UiElement : ISelectable
{
    private Color _color = Color.White;


    public void Select()
    {
        _color = Color.Black;
        Console.WriteLine(_color);
    }

    public void Unselect()
    {
        _color = Color.White;
        Console.WriteLine(_color);
    }
}
