using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodWlasciciel
{
    public decimal IdOsoba { get; set; }

    public virtual ICollection<HodWlascicielPy> HodWlascicielPies { get; set; } = new List<HodWlascicielPy>();

    public virtual HodOsoby IdOsobaNavigation { get; set; } = null!;
}
