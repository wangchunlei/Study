namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridRowBuilderDecoratorProvider
    {
        IGridRowBuilder ApplyDecorators(IGridRowBuilder gridRowBuilder, GridItem item, bool hasDetailView);
    }
}