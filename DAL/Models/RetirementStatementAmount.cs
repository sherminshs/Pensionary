using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RetirementStatementAmount
{
    public Guid RetirementStatementAmountId { get; set; }

    public Guid RetirementStatementId { get; set; }

    public Guid? RetirementStatementRelatedId { get; set; }

    public Guid? RetirementStatementItemId { get; set; }

    public decimal? RetirementStatementItemAmount { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual RetirementStatement RetirementStatement { get; set; } = null!;

    public virtual RetirementStatementItem? RetirementStatementItem { get; set; }

    public virtual RetirementStatementRelated? RetirementStatementRelated { get; set; }
}
