using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodChoroby
{
    public decimal IdChoroby { get; set; }

    public DateOnly? DataRozpoznania { get; set; }

    public string? Rozpoznanie { get; set; }

    public string? Leczenie { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public decimal HodWeterynarzIdOsoba { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }

    public virtual HodWeterynarz HodWeterynarzIdOsobaNavigation { get; set; } = null!;
}
