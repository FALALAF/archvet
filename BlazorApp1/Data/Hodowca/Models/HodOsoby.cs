using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodOsoby
{
    public decimal IdOsoba { get; set; }

    public string? Nazwisko { get; set; }

    public string? Imie { get; set; }

    public virtual ICollection<HodOraganOrganizacji> HodOraganOrganizacjis { get; set; } = new List<HodOraganOrganizacji>();

    public virtual ICollection<HodSedziowie> HodSedziowies { get; set; } = new List<HodSedziowie>();

    public virtual HodWeterynarz? HodWeterynarz { get; set; }

    public virtual HodWlasciciel? HodWlasciciel { get; set; }
}
