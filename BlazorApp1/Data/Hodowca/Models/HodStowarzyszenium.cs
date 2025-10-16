using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodStowarzyszenium
{
    public decimal IdOrganizacji { get; set; }

    public virtual ICollection<HodOddzial> HodOddzialHodStowarzyszeniaIdOrganizacjiNavigations { get; set; } = new List<HodOddzial>();

    public virtual HodOddzial? HodOddzialIdOrganizacjiNavigation { get; set; }

    public virtual HodOraganOrganizacji? HodOraganOrganizacji { get; set; }

    public virtual ICollection<HodSedziowie> HodSedziowies { get; set; } = new List<HodSedziowie>();

    public virtual HodOrganizacje IdOrganizacjiNavigation { get; set; } = null!;
}
