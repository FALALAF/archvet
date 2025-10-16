using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodAdre
{
    public decimal IdAdres { get; set; }

    public string? TypAdresu { get; set; }

    public string? Panstwo { get; set; }

    public string? Miejscowosc { get; set; }

    public string? Adres { get; set; }

    public string? EMail { get; set; }

    public string? Www { get; set; }

    public string? Telefon { get; set; }

    public string? Mobile { get; set; }

    public string? Tabela { get; set; }

    public decimal HodOsobyIdOsoba { get; set; }

    public decimal IdOrganizacji { get; set; }

    public virtual ICollection<HodHodowlaAdre> HodHodowlaAdres { get; set; } = new List<HodHodowlaAdre>();
}
