using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodHodowlaAdre
{
    public decimal IdZlaczenieAdres { get; set; }

    public decimal? HodAdresIdAdres { get; set; }

    public decimal? HodHodowlaIdHodowli { get; set; }

    public virtual HodAdre? HodAdresIdAdresNavigation { get; set; }

    public virtual HodHodowla? HodHodowlaIdHodowliNavigation { get; set; }
}
