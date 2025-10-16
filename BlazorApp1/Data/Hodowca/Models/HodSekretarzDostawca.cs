using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Hodowca.Models;

public partial class HodSekretarzDostawca
{
    public decimal HodUsersId2 { get; set; }

    public decimal HodUsersId { get; set; }

    public virtual HodUser HodUsers { get; set; } = null!;

    public virtual HodUser HodUsersId2Navigation { get; set; } = null!;
}
