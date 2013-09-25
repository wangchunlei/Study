using System.Collections.Generic;
namespace Domas.Web.Mvc.UI
{
    public class ListViewSelectionSettings
    {
        public ListViewSelectionSettings()
        {
            Mode = ListViewSelectionMode.Single;            
        }

        public bool Enabled
        {
            get;
            set;
        }

        public ListViewSelectionMode Mode
        {
            get;
            set;
        }
    }       
}
