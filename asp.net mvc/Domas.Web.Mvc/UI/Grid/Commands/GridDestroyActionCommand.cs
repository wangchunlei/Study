namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Resources;
    using Domas.Web.Mvc.UI.Html;

    public class GridDestroyActionCommand : GridActionCommandBase
    {
        public GridDestroyActionCommand()
        {
            Text = Messages.Grid_Destroy;
        }

        public override string Name
        {
            get { return "destroy"; }
        }

        public override IEnumerable<IGridButtonBuilder> CreateDisplayButtons(IGridUrlBuilder urlBuilder, IGridHtmlHelper htmlHelper)
        {
            var deleteButton = CreateButton<GridFormButtonBuilder>(Text, UIPrimitives.Grid.Delete);

            deleteButton.Url = urlBuilder.DeleteUrl;

            deleteButton.HtmlHelper = htmlHelper;

            deleteButton.SpriteCssClass = "k-delete";

            return new[] { deleteButton };
        }
    }
}
