using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodAdresOsoby
{
    public decimal HodOsobyIdOsoba { get; set; }

    public decimal HodAdresIdAdres { get; set; }

    public virtual HodAdre HodAdresIdAdresNavigation { get; set; } = null!;

    public virtual HodOsoby HodOsobyIdOsobaNavigation { get; set; } = null!;
}
