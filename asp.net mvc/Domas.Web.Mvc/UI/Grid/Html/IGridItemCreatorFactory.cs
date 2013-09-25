namespace Domas.Web.Mvc.UI.Html
{
    public interface IGridItemCreatorFactory
    {
        IGridItemCreator Create(IGridDataKeyStore dataKeyData, IGridItemCreatorData creatorData);
    }
}