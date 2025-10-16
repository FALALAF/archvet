using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodAdresOrganizacja
{
    public decimal HodOrganizacjeIdOrganizacji { get; set; }

    public decimal HodAdresIdAdres { get; set; }

    public virtual HodAdre HodAdresIdAdresNavigation { get; set; } = null!;

    public virtual HodOrganizacje HodOrganizacjeIdOrganizacjiNavigation { get; set; } = null!;
}
