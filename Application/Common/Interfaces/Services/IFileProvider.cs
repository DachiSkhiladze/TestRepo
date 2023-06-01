namespace Application.Common.Interfaces.Services;

public interface IFileProvider
{
    byte[] GetBytesFromFormFile(IFormFile file);
}
