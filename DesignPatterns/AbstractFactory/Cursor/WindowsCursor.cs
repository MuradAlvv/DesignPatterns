
namespace DesignPatterns.AbstractFactory.Cursor
{
    internal class WindowsCursor : ICursor
    {
        public void Hide()
        {
            Console.WriteLine("windows cursor hided");
        }

        public void Render()
        {
            Console.WriteLine("rendering");
        }

        public void Show()
        {
            Console.WriteLine("windwos cursor shown");
        }
    }
}
