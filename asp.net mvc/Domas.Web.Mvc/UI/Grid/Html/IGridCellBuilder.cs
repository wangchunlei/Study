namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridCellBuilder : IGridDecoratableCellBuilder
    {
        IHtmlNode CreateCell();
    }
}