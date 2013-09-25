namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class ChartPlotBandsSerializer<T> : IChartSerializer
        where T : struct
    {
        private readonly ChartPlotBand<T> plotBands;

        public ChartPlotBandsSerializer(ChartPlotBand<T> plotBands)
        {
            this.plotBands = plotBands;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();
                
            FluentDictionary.For(result)
                .Add("from", plotBands.From, () => plotBands.From.HasValue)
                .Add("to", plotBands.To, () => plotBands.To.HasValue)
                .Add("color", plotBands.Color, () => plotBands.Color.HasValue())
                .Add("opacity", plotBands.Opacity, () => plotBands.Opacity.HasValue);

            return result;
        }
    }
}