namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridHtmlBuilderFactory
    {
        IGridHtmlBuilder CreateBuilder(bool scrollable);
    }

}
