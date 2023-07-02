
namespace DesignPatterns.Facade
{
    internal class VideoConverter  //FACADE class
    {
        private readonly CodecFactory _codecFactory = new();

        public VideoFile Convert(VideoFile file, VideoType outputType)
        {
            Codec codec = _codecFactory.ExtractCodec(file.Type);
            Codec destinationCodec = _codecFactory.ExtractCodec(outputType);
            // ... here must be conversion 
            VideoFile result = new VideoFile(file.VideoName);
            result.Type = outputType;
            return result;
        }
    }
}
