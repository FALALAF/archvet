using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodSpotkanie
{
    public decimal Id { get; set; }

    public DateTime? DataUmowienia { get; set; }

    public DateTime? PoczatekSpotkania { get; set; }

    public DateTime? KoniecSpotkania { get; set; }

    public string? Uwagi { get; set; }

    public string? Hash1 { get; set; }

    public decimal? JestNiedostepny { get; set; }

    public decimal? HodUsersId { get; set; }

    public decimal? HodUsersId2 { get; set; }

    public decimal? HodUslugaId { get; set; }

    public string? IdGoogleCalendar { get; set; }

    public virtual HodUser? HodUsers { get; set; }

    public virtual HodUser? HodUsersId2Navigation { get; set; }

    public virtual HodUsluga? HodUsluga { get; set; }
}
