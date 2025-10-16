using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodKrycie
{
    public decimal IdKrycie { get; set; }

    public decimal? HodPiesIdPsa { get; set; }

    public DateOnly? Data { get; set; }

    public decimal? HodPiesIdPsa1 { get; set; }

    public virtual ICollection<HodMiot> HodMiots { get; set; } = new List<HodMiot>();

    public virtual HodPy? HodPiesIdPsa1Navigation { get; set; }

    public virtual HodPy? HodPiesIdPsaNavigation { get; set; }
}
