using System.Collections.Generic;
using System.Web;

namespace Domas.Web.Mvc.UI
{
    public interface IDirectoryBrowser
    {
        IEnumerable<ImageBrowserEntry> GetFiles(string path, string filter);

        IEnumerable<ImageBrowserEntry> GetDirectories(string path);

        HttpServerUtilityBase Server
        {
            get;
            set;
        }
    }
}
