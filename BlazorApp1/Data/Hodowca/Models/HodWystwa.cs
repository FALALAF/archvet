using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodWystwa
{
    public decimal IdWystwa { get; set; }

    public string? Nazwa { get; set; }

    public string? Ranga { get; set; }

    public decimal? Panstwo { get; set; }

    public string? Adres { get; set; }

    public string? Miasto { get; set; }

    public string? DaneGps { get; set; }

    public DateOnly? DataOd { get; set; }

    public DateOnly? DataDo { get; set; }

    public virtual ICollection<HodKatalogWystawy> HodKatalogWystawies { get; set; } = new List<HodKatalogWystawy>();
}
