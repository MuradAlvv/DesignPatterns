
namespace DesignPatterns.Facade
{
    internal class VideoFile
    {
        public string VideoName { get; set; }
        public VideoType Type { get; set; }

        public VideoFile(string fileName)
        {
            VideoName = fileName;
        }
    }
}
