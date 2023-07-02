using DesignPatterns.AbstractFactory.Button;
using DesignPatterns.AbstractFactory.Cursor;

namespace DesignPatterns.AbstractFactory
{
    internal class MacGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICursor CreateCursor()
        {
            return new MacCursor();
        }
    }
}
