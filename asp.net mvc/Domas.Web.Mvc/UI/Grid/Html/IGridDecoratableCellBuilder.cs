namespace Domas.Web.Mvc.UI.Html
{
    using System.Collections.Generic;
    
    public interface IGridDecoratableCellBuilder
    {
        ICollection<IGridCellBuilderDecorator> Decorators
        {
            get;
        }
    }
}