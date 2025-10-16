using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodOrganizacje
{
    public decimal IdOrganizacji { get; set; }

    public string? Nazwa { get; set; }

    public decimal? TypOrganizacji { get; set; }

    public string? Panstwowosc { get; set; }

    public string? Siedziba { get; set; }

    public DateOnly? DataRejestracji { get; set; }

    public string? MiejsceRejestracji { get; set; }

    public virtual HodKlub? HodKlub { get; set; }

    public virtual HodStowarzyszenium? HodStowarzyszenium { get; set; }
}
