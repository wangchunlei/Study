namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridPagerPagingSectionsBuilder
    {
        IHtmlNode CreateSections(GridPagerData section);
    }
}