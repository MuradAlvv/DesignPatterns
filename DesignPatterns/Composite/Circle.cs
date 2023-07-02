
namespace DesignPatterns.Composite
{
    internal class Circle : Dot
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override string? ToString()
        {
            return string.Format("Circle(radius = {0}, center = ({1}, {2}))", Radius, X, Y);
        }
    }
}
