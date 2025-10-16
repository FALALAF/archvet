using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodUstawieniaUzytkownika
{
    public decimal HodUsersId { get; set; }

    public string? Nazwauzytkownika { get; set; }

    public string? Haslo { get; set; }

    public string? Salt { get; set; }

    public string? PlanPracy { get; set; }

    public decimal? Notifications { get; set; }

    public decimal? GoogleSync { get; set; }

    public string? GoogleToken { get; set; }

    public string? GoogleCalendar { get; set; }

    public decimal? SyncPastDays { get; set; }

    public decimal? SyncFutureDays { get; set; }

    public string? CalendarView { get; set; }

    public virtual HodUser HodUsers { get; set; } = null!;
}
