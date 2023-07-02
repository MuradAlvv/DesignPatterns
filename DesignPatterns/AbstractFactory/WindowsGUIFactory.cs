using DesignPatterns.AbstractFactory.Button;
using DesignPatterns.AbstractFactory.Cursor;

namespace DesignPatterns.AbstractFactory
{
    internal class WindowsGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICursor CreateCursor()
        {
            return new WindowsCursor();
        }
    }
}
