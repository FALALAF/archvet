using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodRasy
{
    public decimal IdRasy { get; set; }

    public string? Nazwa { get; set; }

    public string? Grupa { get; set; }

    public string? IsFci { get; set; }

    public decimal? NrGrupy { get; set; }

    public virtual ICollection<HodPy> HodPies { get; set; } = new List<HodPy>();
}
