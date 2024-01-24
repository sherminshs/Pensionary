using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbretirementStatementState
{
    public string RetirementStatementId { get; set; } = null!;

    public int State { get; set; }

    public byte Accept { get; set; }

    public DateTime Date { get; set; }

    public int NextState { get; set; }

    public string Description { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Id { get; set; } = null!;
}
