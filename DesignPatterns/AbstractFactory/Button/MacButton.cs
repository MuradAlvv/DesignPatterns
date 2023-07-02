
namespace DesignPatterns.AbstractFactory.Button
{
    internal class MacButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("mac button clicked");
        }

        public void Render()
        {
            Console.WriteLine("rendering");
        }
    }
}
