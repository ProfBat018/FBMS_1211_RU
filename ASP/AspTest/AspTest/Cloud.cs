using System;
using System.Collections.Generic;

namespace AspTest;

public partial class Cloud
{
    public int CloudsId { get; set; }

    public int All { get; set; }

    public virtual ICollection<Forecast> Forecasts { get; } = new List<Forecast>();
}
