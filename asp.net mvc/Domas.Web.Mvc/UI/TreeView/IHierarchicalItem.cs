namespace Domas.Web.Mvc.UI
{
    public interface IHierarchicalItem
    {
        string Id { get; }

        bool HasChildren { get; }

        bool Expanded { get; }
    }
}
