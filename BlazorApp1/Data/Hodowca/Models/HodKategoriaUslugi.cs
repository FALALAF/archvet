using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodKategoriaUslugi
{
    public decimal IdKatUslugi { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public virtual ICollection<HodUsluga> HodUslugas { get; set; } = new List<HodUsluga>();
}
