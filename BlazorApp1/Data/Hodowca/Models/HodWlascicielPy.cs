using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodWlascicielPy
{
    public decimal IdWlascicielPies { get; set; }

    public decimal? Udzial { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public decimal? HodWlascicielIdOsoba { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }

    public virtual HodWlasciciel? HodWlascicielIdOsobaNavigation { get; set; }
}
