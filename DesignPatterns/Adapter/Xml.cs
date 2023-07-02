namespace DesignPatterns.Adapter
{
    internal class Xml
    {
        public string Content { get ; set; }

        public Xml(string content)
        {
            Content = content;
        }
    }
}
