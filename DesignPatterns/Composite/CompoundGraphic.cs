
namespace DesignPatterns.Composite
{
    internal class CompoundGraphic : IGraphic
    {
        private readonly List<IGraphic> _children = new();

        public void Draw()
        {
            _children.ForEach(child => child.Draw());
        }

        public void Move(int x, int y)
        {
            _children.ForEach(child => child.Move(x, y));
        }

        public void Remove(IGraphic child)
        {
            _children.Remove(child);
        }

        public void Add(IGraphic child)
        {
            _children.Add(child);
        }
    }
}
