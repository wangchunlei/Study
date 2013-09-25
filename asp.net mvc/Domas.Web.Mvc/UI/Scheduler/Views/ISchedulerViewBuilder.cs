namespace Domas.Web.Mvc.UI
{
    using System;
    using Domas.Web.Mvc.UI.Fluent;

    public interface ISchedulerViewBuilder
    {
        ISchedulerViewBuilder Title(string title);

        ISchedulerViewBuilder Editable(Action<SchedulerViewEditableSettingsBuilder> configurator);

        ISchedulerViewBuilder EventTemplate(string eventTemplate);

        ISchedulerViewBuilder EventTemplateId(string eventTemplate);

        ISchedulerViewBuilder SelectedDateFormat(string selectedDateFormat);

        ISchedulerViewBuilder Selected(bool isSelected);

        ISchedulerViewBuilder Groups(SchedulerGroupOrientation orientation);
    }
}
