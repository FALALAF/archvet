using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodOtrzymaneTytuly
{
    public decimal IdOtrzymane { get; set; }

    public DateOnly? DataOtrzymania { get; set; }

    public decimal? HodTytulyIdTytulu { get; set; }

    public decimal? HodKatalogWystawyIdKatalog { get; set; }

    public decimal? Sedzia { get; set; }

    public decimal? HodKatalogWystawyHodRingIdRingu { get; set; }

    public virtual HodKatalogWystawy? HodKatalogWystawyIdKatalogNavigation { get; set; }

    public virtual HodTytuly? HodTytulyIdTytuluNavigation { get; set; }
}
