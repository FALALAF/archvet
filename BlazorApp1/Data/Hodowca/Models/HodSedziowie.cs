using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodSedziowie
{
    public decimal IdSedzia { get; set; }

    public decimal IdOsoba { get; set; }

    public decimal HodStowarzyszeniaIdOrganizacji { get; set; }

    public virtual ICollection<HodOcena> HodOcenas { get; set; } = new List<HodOcena>();

    public virtual HodStowarzyszenium HodStowarzyszeniaIdOrganizacjiNavigation { get; set; } = null!;

    public virtual ICollection<HodUprawnienium> HodUprawnienia { get; set; } = new List<HodUprawnienium>();

    public virtual HodOsoby IdOsobaNavigation { get; set; } = null!;
}
