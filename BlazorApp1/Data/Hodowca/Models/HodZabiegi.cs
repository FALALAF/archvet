using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodZabiegi
{
    public decimal IdZabieg { get; set; }

    public DateOnly? DataZabiegu { get; set; }

    public DateOnly? WymaganaDataNastepnego { get; set; }

    public string? RodzajZabiegu { get; set; }

    public string? Uwagi { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public string? KodKreskowy { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }
}
