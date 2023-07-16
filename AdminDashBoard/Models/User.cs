using System;
using System.Collections.Generic;

namespace AdminDashBoard.Models;

public partial class User
{
    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int UserId { get; set; }
}
