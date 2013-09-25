namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridPagerSectionsBuilder
    {
        IHtmlNode CreateSections(GridPagerData section);
    }
}