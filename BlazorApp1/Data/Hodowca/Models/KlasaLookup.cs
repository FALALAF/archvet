using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class KlasaLookup
{
    public decimal KlasaId { get; set; }

    public string Nazwa { get; set; } = null!;

    public byte OdIleMiesiecy { get; set; }

    public byte? DoIleMiesiecy { get; set; }

    public string? TypOceny { get; set; }
}
