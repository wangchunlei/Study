namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridPagerNumericSectionBuilder
    {
        IHtmlNode Create(IGridUrlBuilder urlBuilder, int currentPage, int pageCount, int buttonCount);
    }
}