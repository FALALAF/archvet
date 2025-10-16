using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodUzytkownik
{
    public decimal IdOsoba { get; set; }

    public virtual HodOsoby IdOsobaNavigation { get; set; } = null!;
}
