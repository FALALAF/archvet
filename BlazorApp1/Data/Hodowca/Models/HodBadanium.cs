using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodBadanium
{
    public decimal IdBadania { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public byte[]? Wyniki { get; set; }

    public string? WynikiXml { get; set; }

    public decimal HodWeterynarzIdOsoba { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }

    public virtual HodWeterynarz HodWeterynarzIdOsobaNavigation { get; set; } = null!;
}
