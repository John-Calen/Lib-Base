namespace Base.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static byte[] ReadAllBytes(this BinaryReader reader)
        {
            const int bufferSize = 4096;
            var buffer = new byte[bufferSize];

            using var memoryStream = new MemoryStream();

            int count;
            while ((count = reader.Read(buffer, 0, buffer.Length)) is not 0)
                memoryStream.Write(buffer, 0, count);

            return memoryStream.ToArray();
        }
    }
}
