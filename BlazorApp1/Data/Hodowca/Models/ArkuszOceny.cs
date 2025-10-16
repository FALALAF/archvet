using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class ArkuszOceny
{
    public string? NazwaPsa { get; set; }

    public DateOnly? DataUrodzeniaPsa { get; set; }

    public string? MascPsa { get; set; }

    public string? NrRodowodu { get; set; }

    public string? RejOddzialowa { get; set; }

    public string? NumerMikroczipu { get; set; }

    public string? NazwaRasy { get; set; }

    public string? NazwaWystawy { get; set; }

    public string? RangaWystawy { get; set; }

    public string? MiastoWywy { get; set; }

    public DateOnly? DataOd { get; set; }

    public DateOnly? DataDo { get; set; }

    public decimal? Lokata { get; set; }

    public decimal? NrKatalogowy { get; set; }

    public string? Plec { get; set; }

    public string? NazwaHodowli { get; set; }

    public string? Klasa { get; set; }

    public string? Ocena { get; set; }

    public string? Uzasadnienie { get; set; }

    public string? Ring { get; set; }

    public decimal? Udzial { get; set; }

    public string? Nazwisko { get; set; }

    public string? Imie { get; set; }
}
