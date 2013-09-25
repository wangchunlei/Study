using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domas.Web.Mvc.UI
{
    public class BarcodeSpacing:ChartSpacing
    {
        public bool ShouldSerialize()
        {
            return this.Bottom.HasValue || this.Top.HasValue || this.Left.HasValue || this.Right.HasValue;
        }
    }
}
