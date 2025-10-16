using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodWeterynarz
{
    public decimal IdOsoba { get; set; }

    public string? NrPwz { get; set; }

    public virtual ICollection<HodAlergie> HodAlergies { get; set; } = new List<HodAlergie>();

    public virtual ICollection<HodBadanium> HodBadania { get; set; } = new List<HodBadanium>();

    public virtual ICollection<HodChoroby> HodChorobies { get; set; } = new List<HodChoroby>();

    public virtual ICollection<HodMiot> HodMiots { get; set; } = new List<HodMiot>();

    public virtual HodOsoby IdOsobaNavigation { get; set; } = null!;

    public virtual ICollection<HodSpecjalizacja> HodSpecjalizacjaIdSpecjalizacjas { get; set; } = new List<HodSpecjalizacja>();
}
