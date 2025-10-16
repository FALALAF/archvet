using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodKatalogWystawy
{
    public decimal HodKatalogWystawyId { get; set; }

    public decimal IdKatalog { get; set; }

    public decimal? NrKatalogowy { get; set; }

    public decimal? Lokata { get; set; }

    public decimal HodPiesIdPsa { get; set; }

    public decimal? HodWystwaIdWystwa { get; set; }

    public decimal HodRingIdRingu { get; set; }

    public decimal? KlasaId { get; set; }

    public virtual ICollection<HodOcena> HodOcenas { get; set; } = new List<HodOcena>();

    public virtual ICollection<HodOtrzymaneTytuly> HodOtrzymaneTytulies { get; set; } = new List<HodOtrzymaneTytuly>();

    public virtual HodPy HodPiesIdPsaNavigation { get; set; } = null!;

    public virtual HodRing HodRingIdRinguNavigation { get; set; } = null!;

    public virtual HodWystwa? HodWystwaIdWystwaNavigation { get; set; }

    public virtual HodKlasa? Klasa { get; set; }
}
