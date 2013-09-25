using System.IO;

namespace Domas.Web.Mvc.UI
{
    public interface IThumbnailCreator
    {
        byte[] Create(Stream source, ImageSize desiredSize, string contentType);
    }
}
