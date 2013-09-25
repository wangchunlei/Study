namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;

    internal class GaugeLinearScaleSerializer : GaugeScaleSerializerBase
    {
        private readonly ILinearScale scale;

        public GaugeLinearScaleSerializer(ILinearScale scale)
            : base(scale)
        {
            this.scale = scale;
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();
            FluentDictionary.For(result)
                .Add("mirror", scale.Mirror, () => scale.Mirror.HasValue)
                .Add("vertical", scale.Vertical, () => scale.Vertical.HasValue);

            var labelsData = scale.Labels.CreateSerializer().Serialize();
            if (labelsData.Count > 0)
            {
                result.Add("labels", labelsData);
            }

            return result;
        }
    }
}
