namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class ChartAxisCrosshairSerializer : ChartLineBaseSerializer
    {
        private readonly ChartAxisCrosshair crosshair;

        public ChartAxisCrosshairSerializer(ChartAxisCrosshair crosshair)
            : base(crosshair)
        {
            this.crosshair = crosshair;
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();

            var tooltip = crosshair.Tooltip.CreateSerializer().Serialize();
            if (tooltip.Keys.Count > 0)
            {
                result.Add("tooltip", tooltip);
            }

            return result;
        }
    }
}