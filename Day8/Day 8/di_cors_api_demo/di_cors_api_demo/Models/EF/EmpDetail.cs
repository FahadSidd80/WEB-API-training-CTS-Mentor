using System;
using System.Collections.Generic;

namespace di_cors_api_demo.Models.EF;

public partial class EmpDetail
{
    public int EmpNo { get; set; }

    public string EmpName { get; set; } = null!;

    public double EmpSalary { get; set; }

    public string EmpCity { get; set; } = null!;

    public bool EmpIsPermenant { get; set; }
}
