namespace Domas.Web.Mvc.UI
{
    using System.Web.Mvc;
    using Domas.Web.Mvc.UI.Fluent;

    public static class HtmlHelperExtension
    {
        public static WidgetFactory Kendo(this HtmlHelper helper)
        {
            return new WidgetFactory(helper);
        }

        public static WidgetFactory<TModel> Kendo<TModel>(this HtmlHelper<TModel> helper)
        {
            return new WidgetFactory<TModel>(helper);
        }
    }
}