namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    
    public interface IChartSerializer
    {
        /// <summary>
        /// Serializes the current instance
        /// </summary>
        IDictionary<string, object> Serialize();
    }
}
