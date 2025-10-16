using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodPy
{
    public decimal IdPsa { get; set; }

    public string? Nazwa { get; set; }

    public DateOnly? DataUrodzenia { get; set; }

    public string? Masc { get; set; }

    public string? NrRodowodu { get; set; }

    public string? RejOddzialowa { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public decimal? HodPiesIdPsa2 { get; set; }

    public decimal? HodHodowlaIdHodowli { get; set; }

    public string? PlecDonotuse { get; set; }

    public string? TypOkrywyWlosowej { get; set; }

    public string? RodzajMikroczipu { get; set; }

    public string? NumerMikroczipu { get; set; }

    public DateOnly? DataWszczepienia { get; set; }

    public string? Umiejscowienie { get; set; }

    public string? NumerTatuazu { get; set; }

    public DateOnly? DataTatuazu { get; set; }

    public decimal HodRasyIdRasy { get; set; }

    public virtual ICollection<HodAlergie> HodAlergies { get; set; } = new List<HodAlergie>();

    public virtual ICollection<HodBadanium> HodBadania { get; set; } = new List<HodBadanium>();

    public virtual ICollection<HodChoroby> HodChorobies { get; set; } = new List<HodChoroby>();

    public virtual HodHodowla? HodHodowlaIdHodowliNavigation { get; set; }

    public virtual ICollection<HodKatalogWystawy> HodKatalogWystawies { get; set; } = new List<HodKatalogWystawy>();

    public virtual ICollection<HodKrycie> HodKrycieHodPiesIdPsa1Navigations { get; set; } = new List<HodKrycie>();

    public virtual ICollection<HodKrycie> HodKrycieHodPiesIdPsaNavigations { get; set; } = new List<HodKrycie>();

    public virtual HodPy? HodPiesIdPsa2Navigation { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }

    public virtual HodRasy HodRasyIdRasyNavigation { get; set; } = null!;

    public virtual ICollection<HodRozrod> HodRozrods { get; set; } = new List<HodRozrod>();

    public virtual ICollection<HodWlascicielPy> HodWlascicielPies { get; set; } = new List<HodWlascicielPy>();

    public virtual ICollection<HodZabiegi> HodZabiegis { get; set; } = new List<HodZabiegi>();

    public virtual ICollection<HodZapobieganieCiazy> HodZapobieganieCiazies { get; set; } = new List<HodZapobieganieCiazy>();

    public virtual ICollection<HodPy> InverseHodPiesIdPsa2Navigation { get; set; } = new List<HodPy>();

    public virtual ICollection<HodPy> InverseHodPiesIdPsaNavigation { get; set; } = new List<HodPy>();
}
