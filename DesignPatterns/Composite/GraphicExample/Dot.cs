namespace DesignPatterns.Composite.GraphicExample
{
    internal class Dot : IGraphic
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override string? ToString()
        {
            return string.Format("dot(x = {0}, y = {1})", X, Y);
        }
    }
}