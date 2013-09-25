namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridGroupHeaderBuilder
    {
        IHtmlNode CreateGroupHeader(GridGroupingData groupingData);
    }
}