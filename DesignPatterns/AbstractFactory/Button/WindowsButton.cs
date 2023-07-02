
namespace DesignPatterns.AbstractFactory.Button
{
    internal class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("windows button clicked");
        }

        public void Render()
        {
            Console.WriteLine("rendering");
        }
    }
}
