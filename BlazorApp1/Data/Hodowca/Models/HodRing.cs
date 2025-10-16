using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodRing
{
    public string? Nazwa { get; set; }

    public decimal IdRingu { get; set; }

    public virtual ICollection<HodKatalogWystawy> HodKatalogWystawies { get; set; } = new List<HodKatalogWystawy>();
}
