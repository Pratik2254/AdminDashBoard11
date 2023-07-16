using System;
using System.Collections.Generic;

namespace AdminDashBoard.Models;

public partial class Login
{
    public int UserId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
