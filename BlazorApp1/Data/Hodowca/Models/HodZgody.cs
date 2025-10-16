using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodZgody
{
    public decimal Id { get; set; }

    public DateTime? Utworzone { get; set; }

    public DateTime? Zmodyfikowany { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Email { get; set; }

    public string? Ip { get; set; }

    public string? Typ { get; set; }
}
