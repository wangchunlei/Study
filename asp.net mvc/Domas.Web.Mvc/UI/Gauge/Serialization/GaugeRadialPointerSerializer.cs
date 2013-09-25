namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class GaugeRadialPointerSerializer : IChartSerializer
    {
        private readonly GaugeRadialPointer pointer;

        public GaugeRadialPointerSerializer(GaugeRadialPointer pointer)
        {
            this.pointer = pointer;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();

            FluentDictionary.For(result)
                .Add("color", pointer.Color, () => pointer.Color.HasValue())
                .Add("opacity", pointer.Opacity, () => pointer.Opacity.HasValue)
                .Add("value", pointer.Value, () => pointer.Value.HasValue);

            var cap = pointer.Cap.CreateSerializer().Serialize();

            if (cap.Count > 0) 
            {
                result.Add("cap", cap);
            }

            return result;
        }
    }
}