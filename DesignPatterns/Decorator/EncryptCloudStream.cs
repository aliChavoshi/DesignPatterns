namespace DesignPatterns.Decorator
{
    public class EncryptCloudStream : IStream
    {
        private readonly IStream _stream;
        public EncryptCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var encrypt = EncryptData(data);
            _stream.Write(encrypt);
        }

        private string EncryptData(string data)
        {
            return "NIUHDT#*&R&$^G#";
        }
    }
}