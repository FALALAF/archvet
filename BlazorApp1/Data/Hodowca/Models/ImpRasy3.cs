using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class ImpRasy3
{
    public decimal Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Grupa { get; set; } = null!;

    public string IsFci { get; set; } = null!;

    public int NrGrupy { get; set; }
}
