using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodZapobieganieCiazy
{
    public decimal IdZapobieganie { get; set; }

    public decimal? DataWykonania { get; set; }

    public string? Rodzaj { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }
}
