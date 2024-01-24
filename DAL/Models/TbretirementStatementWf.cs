using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbretirementStatementWf
{
    public string Id { get; set; } = null!;

    public string? Condition { get; set; }

    public int? ConditionValue { get; set; }

    public int? NextState { get; set; }

    public string? Page { get; set; }

    public string? Role { get; set; }

    public string? State { get; set; }

    public string? StateName { get; set; }

    public string? StateMessage { get; set; }

    public bool? IsActive { get; set; }
}
