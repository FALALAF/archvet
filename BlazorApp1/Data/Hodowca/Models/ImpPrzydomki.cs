using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class ImpPrzydomki
{
    public decimal Id { get; set; }

    public string Przydomek { get; set; } = null!;

    public string? Hodowla { get; set; }

    public string? Przynaleznosc { get; set; }
}
