namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class GaugeLinearScaleLabelsSerializer : GaugeScaleLabelsSerializerBase
    {
        private readonly GaugeLinearScaleLabels labels;

        public GaugeLinearScaleLabelsSerializer(GaugeLinearScaleLabels labels)
            : base(labels)
        {
            this.labels = labels;
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();

            return result;
        }
    }
}