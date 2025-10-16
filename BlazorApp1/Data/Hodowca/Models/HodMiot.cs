using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodMiot
{
    public decimal IdMiot { get; set; }

    public decimal? HodKrycieIdKrycie { get; set; }

    public DateOnly? DataPorodu { get; set; }

    public decimal? WielkoscMiotuSuki { get; set; }

    public decimal? WielkoscMiotuPsy { get; set; }

    public string? Uwagi { get; set; }

    public decimal HodWeterynarzIdOsoba { get; set; }

    public virtual HodKrycie? HodKrycieIdKrycieNavigation { get; set; }

    public virtual HodWeterynarz HodWeterynarzIdOsobaNavigation { get; set; } = null!;
}
