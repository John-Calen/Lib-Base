namespace Base.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream input, int bufferSize = 16 * 1024)
        {
            if (input is MemoryStream memStream)
                return memStream.ToArray();

            byte[] buffer = new byte[bufferSize];
            using var memoryStream = new MemoryStream();
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                memoryStream.Write(buffer, 0, read);

            return memoryStream.ToArray();
        }
    }
}
