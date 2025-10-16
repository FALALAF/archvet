using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodRole
{
    public decimal Id { get; set; }

    public string? Nazwa { get; set; }

    public string? Slug { get; set; }

    public decimal? CzyAdmin { get; set; }

    public decimal? Spotkanie { get; set; }

    public decimal? Klient { get; set; }

    public decimal? Usluga { get; set; }

    public decimal? Uzytkownik { get; set; }

    public decimal? UstawieniaSystemowe { get; set; }

    public decimal? UstawieniaUzytkownika { get; set; }

    public virtual ICollection<HodUser> HodUsers { get; set; } = new List<HodUser>();
}
