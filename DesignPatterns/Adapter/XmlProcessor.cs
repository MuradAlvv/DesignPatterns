namespace DesignPatterns.Adapter
{
    internal class XmlProcessor : IXmlProcessor
    {
        public void Process(Xml xml)
        {
            Console.WriteLine("processing xml");
        }
    }
}
