
namespace DesignPatterns.Facade
{
    internal class CodecFactory
    {
        public Codec ExtractCodec(VideoType type)
        {
            Codec codec = type switch
            {
                VideoType.MP4 => new Codec(), //must be Mp4Codec
                _ => throw new ArgumentException(),
            };
            return codec;
        }
    }
}

