using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PensionaryComplementary
{
    public Guid PensionaryComplementaryId { get; set; }

    public Guid PersonId { get; set; }

    public DateTime? RetirementDate { get; set; }

    public string? RetirementSolarDate { get; set; }

    public int? RetiredGroup { get; set; }

    public int? RetiredJobDegreeCoef { get; set; }

    public string? RetiredCardCode { get; set; }

    public string? RetiredLastPosition { get; set; }

    public Guid? RetiredOrganizationId { get; set; }

    public int? RetiredRealDuration { get; set; }

    public int? RetiredGrantDuration { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual Person Person { get; set; } = null!;
}
