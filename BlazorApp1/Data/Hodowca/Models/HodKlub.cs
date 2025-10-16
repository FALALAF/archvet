using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodKlub
{
    public decimal IdOrganizacji { get; set; }

    public decimal HodOddzialIdOrganizacji { get; set; }

    public virtual HodOddzial HodOddzialIdOrganizacjiNavigation { get; set; } = null!;

    public virtual HodOrganizacje IdOrganizacjiNavigation { get; set; } = null!;
}
