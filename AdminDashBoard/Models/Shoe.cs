using System;
using System.Collections.Generic;

namespace AdminDashBoard.Models;

public partial class Shoe
{
    public int ShoesId { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? AddedBy { get; set; }
}
