using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodOcena
{
    public decimal IdOceny { get; set; }

    public decimal? IdKatalog { get; set; }

    /// <summary>
    /// Jesli jest to oficjalna ocena to id jest przepisane z katalogu
    /// </summary>
    public decimal? IdSedziego { get; set; }

    public string? CoOceniamy { get; set; }

    public decimal? OcenaPunktowa { get; set; }

    public string? Ocena { get; set; }

    /// <summary>
    /// Cxy to jest oficjalna ocena czy jest zabawa widzów
    /// </summary>
    public string? Oficjalna { get; set; }

    public decimal KatKatWystawyId { get; set; }

    public string? Uzasadnienie { get; set; }

    public virtual HodSedziowie? IdSedziegoNavigation { get; set; }

    public virtual HodKatalogWystawy KatKatWystawy { get; set; } = null!;
}
