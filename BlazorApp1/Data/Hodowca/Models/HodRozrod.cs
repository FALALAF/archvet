using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodRozrod
{
    public decimal IdRozrod { get; set; }

    public decimal? PerwszaCieczka { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }
}
