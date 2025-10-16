using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodPiesWhodowliView
{
    public string? Nazwa { get; set; }

    public string? NazwaPsa { get; set; }

    public DateOnly? DataUrodzenia { get; set; }

    public string? Masc { get; set; }

    public string? NrRodowodu { get; set; }

    public string? RejOddzialowa { get; set; }

    public string? Plec { get; set; }
}
