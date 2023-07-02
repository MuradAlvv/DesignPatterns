
using DesignPatterns.AbstractFactory.Button;
using DesignPatterns.AbstractFactory.Cursor;

namespace DesignPatterns.AbstractFactory
{
    internal interface IGUIFactory
    {
        IButton CreateButton();
        ICursor CreateCursor();
    }
}
