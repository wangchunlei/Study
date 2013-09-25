namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class ChartNoteLineSerializer : IChartSerializer
    {
        private readonly ChartNoteLine line;

        public ChartNoteLineSerializer(ChartNoteLine line)
        {
            this.line = line;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();

            FluentDictionary.For(result)
                .Add("width", line.Width, () => line.Width.HasValue)
                .Add("color", line.Color, () => line.Color.HasValue())
                .Add("length", line.Length, () => line.Length.HasValue);

            return result;
        }
    }
}