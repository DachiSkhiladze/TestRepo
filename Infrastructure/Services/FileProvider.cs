namespace Infrastructure.Services;

public class FileProvider : IFileProvider
{
    public byte[] GetBytesFromFormFile(IFormFile file)
    {
        try
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
        catch (Exception ex)
        {
            return new byte[] { };
        }
    }
}
