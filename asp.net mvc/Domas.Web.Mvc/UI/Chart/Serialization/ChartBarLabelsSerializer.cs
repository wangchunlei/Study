namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Extensions;
    using Domas.Web.Mvc.Infrastructure;

    internal class ChartBarLabelsSerializer : ChartLabelsBase
    {
        private readonly ChartBarLabels barLabels;

        public ChartBarLabelsSerializer(ChartBarLabels barLabels)
            : base(barLabels)
        {
            this.barLabels = barLabels;
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();

            if (barLabels.Position.HasValue)
            {
                FluentDictionary.For(result)
                    .Add("position", barLabels.Position.ToString().ToCamelCase());
            }

            return result;
        }
    }
}