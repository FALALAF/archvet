using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodUprawnienium
{
    public decimal IdUprawnienia { get; set; }

    public decimal? IdRasa { get; set; }

    public string? Ranga { get; set; }

    public decimal HodSedziowieIdSedzia { get; set; }

    public virtual HodSedziowie HodSedziowieIdSedziaNavigation { get; set; } = null!;
}
