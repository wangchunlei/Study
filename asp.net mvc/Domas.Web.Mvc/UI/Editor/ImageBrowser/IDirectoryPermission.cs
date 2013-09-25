namespace Domas.Web.Mvc.UI
{
    public interface IDirectoryPermission
    {
        bool CanAccess(string rootPath, string childPath);
    }
}
