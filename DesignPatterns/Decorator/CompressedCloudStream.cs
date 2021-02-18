namespace DesignPatterns.Decorator
{
    public class CompressedCloudStream : IStream
    {
        private readonly IStream _stream;
        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var compressed = Compressing(data);
            _stream.Write(compressed);
        }

        private string Compressing(string data)
        {
            return data.Substring(0, 3);
        }
    }
}