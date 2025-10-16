using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodKlasa
{
    public decimal KlasaId { get; set; }

    public string? Nazwa { get; set; }

    public decimal? OdIleMiesiecy { get; set; }

    public decimal? DoIleMiesiecy { get; set; }

    public decimal? TypOceny { get; set; }

    public virtual ICollection<HodKatalogWystawy> HodKatalogWystawies { get; set; } = new List<HodKatalogWystawy>();
}
