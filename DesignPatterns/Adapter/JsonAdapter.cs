
namespace DesignPatterns.Adapter
{
    internal class JsonAdapter : IXmlProcessor
    {
        private readonly JsonProcessor _jsonProcessor;

        public JsonAdapter(JsonProcessor jsonProcessor)
        {
            _jsonProcessor = jsonProcessor;
        }

        public void Process(Xml xml)
        {
            Json json = ConvertToJson(xml);
            _jsonProcessor.Process(json);
        }

        public Json ConvertToJson(Xml xml)
        {
            string content = xml.Content;
            return new Json(content);
        }
    }
}
