using System.Collections.Generic;
using Domas.Web.Mvc.Infrastructure;
using Domas.Web.Mvc.Extensions;

namespace Domas.Web.Mvc.UI
{
    internal class ChartDonutSeriesSerializer : ChartPieSeriesSerializer
    {
        private readonly IChartDonutSeries series;

        public ChartDonutSeriesSerializer(IChartDonutSeries series)
            : base(series)
        {
            this.series = series;
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();

            FluentDictionary.For(result)
                .Add("margin", series.Margin, () => series.Margin.HasValue)
                .Add("holeSize", series.HoleSize, () => series.HoleSize.HasValue)
                .Add("size", series.Size, () => series.Size.HasValue);

            return result;
        }
    }
}