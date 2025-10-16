using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodHodowla
{
    public decimal IdHodowli { get; set; }

    public string? Nazwa { get; set; }

    public virtual ICollection<HodHodowlaAdre> HodHodowlaAdres { get; set; } = new List<HodHodowlaAdre>();

    public virtual ICollection<HodPy> HodPies { get; set; } = new List<HodPy>();
}
