using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodSpecjalizacja
{
    public decimal IdSpecjalizacja { get; set; }

    public string? Typ { get; set; }

    public string Nazwa { get; set; } = null!;

    public virtual ICollection<HodWeterynarz> HodWeterynarzIdOsobas { get; set; } = new List<HodWeterynarz>();
}
