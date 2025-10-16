using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodUser
{
    public decimal Id { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Email { get; set; }

    public string? Komorka { get; set; }

    public string? Telefon { get; set; }

    public string? Adres { get; set; }

    public string? Miasto { get; set; }

    public string? Wojewodztwo { get; set; }

    public string? KodPocztowy { get; set; }

    public string? Uwagi { get; set; }

    public decimal HodRoleId { get; set; }

    public decimal Id1 { get; set; }

    public virtual HodRole HodRole { get; set; } = null!;

    public virtual ICollection<HodSpotkanie> HodSpotkanieHodUsers { get; set; } = new List<HodSpotkanie>();

    public virtual ICollection<HodSpotkanie> HodSpotkanieHodUsersId2Navigations { get; set; } = new List<HodSpotkanie>();

    public virtual HodUstawieniaUzytkownika? HodUstawieniaUzytkownika { get; set; }

    public virtual ICollection<HodUsluga> HodUslugas { get; set; } = new List<HodUsluga>();
}
