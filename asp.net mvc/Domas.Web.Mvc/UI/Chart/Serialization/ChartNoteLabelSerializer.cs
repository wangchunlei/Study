namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Extensions;
    using Domas.Web.Mvc.Infrastructure;

    internal class ChartNoteLabelSerializer : ChartLabelsBase
    {
        private readonly ChartNoteLabel label;

        public ChartNoteLabelSerializer(ChartNoteLabel label)
            : base(label)
        {
            this.label = label;
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();
            
            FluentDictionary.For(result)
                .Add("position", label.Position.ToString().ToLowerInvariant(), () => label.Position.HasValue)
                .Add("text", label.Text, () => label.Text.HasValue());

            return result;
        }
    }
}