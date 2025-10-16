using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodTytuly
{
    public decimal IdTytulu { get; set; }

    public string? Nazwa { get; set; }

    public virtual ICollection<HodOtrzymaneTytuly> HodOtrzymaneTytulies { get; set; } = new List<HodOtrzymaneTytuly>();
}
