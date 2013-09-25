namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class GaugeRadialCapSerializer : IChartSerializer
    {
        private readonly GaugeRadialCap cap;

        public GaugeRadialCapSerializer(GaugeRadialCap cap)
        {
            this.cap = cap;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();

            FluentDictionary.For(result)
                .Add("color", cap.Color, () => cap.Color.HasValue())
                .Add("opacity", cap.Opacity, () => cap.Opacity.HasValue)
                .Add("size", cap.Size, () => cap.Size.HasValue);

            return result;
        }
    }
}