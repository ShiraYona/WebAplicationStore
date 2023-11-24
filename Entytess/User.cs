﻿using System;
using System.Collections.Generic;

namespace Entytess;

public partial class User
{
    public int UserId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
