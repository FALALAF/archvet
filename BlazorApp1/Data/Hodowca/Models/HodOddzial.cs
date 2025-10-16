using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodOddzial
{
    public decimal IdOrganizacji { get; set; }

    public decimal HodStowarzyszeniaIdOrganizacji { get; set; }

    public virtual ICollection<HodKlub> HodKlubs { get; set; } = new List<HodKlub>();

    public virtual HodStowarzyszenium HodStowarzyszeniaIdOrganizacjiNavigation { get; set; } = null!;

    public virtual HodStowarzyszenium IdOrganizacjiNavigation { get; set; } = null!;
}
