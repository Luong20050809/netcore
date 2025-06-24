using System;
using System.Collections.Generic;

namespace Nvllesson10.Models;

public partial class Category
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public bool? CateStatus { get; set; }
}
