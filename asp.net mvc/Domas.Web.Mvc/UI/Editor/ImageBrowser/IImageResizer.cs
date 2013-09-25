namespace Domas.Web.Mvc.UI
{
    public interface IImageResizer
    {   
        ImageSize Resize(ImageSize originalSize, ImageSize targetSize);        
    }
}
