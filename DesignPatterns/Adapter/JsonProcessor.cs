
namespace DesignPatterns.Adapter
{
    //external library works with json format
    internal class JsonProcessor : IJsonProcessor
    {
        public void Process(Json json)
        {
            Console.WriteLine("processing json");
        }
    }
}
