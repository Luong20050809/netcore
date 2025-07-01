using System;
using System.Collections.Generic;

namespace NguyenVanLuong_2310900060.Models;

public partial class NvlEmployee
{
    public string NvlEmpId { get; set; } = null!;

    public string? NvlEmpName { get; set; }

    public string? NvlEmpLevel { get; set; }

    public string? NvlEmpStartDate { get; set; }

    public bool? NvlEmpStatus { get; set; }
}
