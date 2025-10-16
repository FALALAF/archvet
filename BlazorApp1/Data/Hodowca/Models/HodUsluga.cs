using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodUsluga
{
    public decimal Id { get; set; }

    public string? Nazwa { get; set; }

    public decimal? CzasTrwania { get; set; }

    public decimal? Cena { get; set; }

    public string? Waluta { get; set; }

    public string? Opis { get; set; }

    public string? DostepnyTyp { get; set; }

    public decimal? LiczbaPersonelu { get; set; }

    public decimal? HodKategoriaUslugiId { get; set; }

    public virtual HodKategoriaUslugi? HodKategoriaUslugi { get; set; }

    public virtual ICollection<HodSpotkanie> HodSpotkanies { get; set; } = new List<HodSpotkanie>();

    public virtual ICollection<HodUser> HodUsers { get; set; } = new List<HodUser>();
}
