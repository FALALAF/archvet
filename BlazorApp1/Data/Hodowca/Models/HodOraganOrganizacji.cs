using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodOraganOrganizacji
{
    public string? Funkcja { get; set; }

    public DateOnly? DataOd { get; set; }

    public DateOnly? DataDo { get; set; }

    public string? TypOrganu { get; set; }

    public decimal HodStowarzyszeniaIdOrganizacji { get; set; }

    public decimal HodOsobyIdOsoba { get; set; }

    public decimal HodOraganOrganizacjiId { get; set; }

    public virtual HodOsoby HodOsobyIdOsobaNavigation { get; set; } = null!;

    public virtual HodStowarzyszenium HodStowarzyszeniaIdOrganizacjiNavigation { get; set; } = null!;
}
