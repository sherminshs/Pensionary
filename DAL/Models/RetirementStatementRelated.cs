using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RetirementStatementRelated
{
    public Guid RetirementStatementRelatedId { get; set; }

    public Guid RetirementStatementId { get; set; }

    public Guid PensionaryId { get; set; }

    /// <summary>
    /// این فرد فعلا حقوق نمی گیرد
    /// </summary>
    public bool? RetirementStatemenRelatedtIsLockedForPayment { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual Pensionary Pensionary { get; set; } = null!;

    public virtual RetirementStatement RetirementStatement { get; set; } = null!;

    public virtual ICollection<RetirementStatementAmount> RetirementStatementAmounts { get; set; } = new List<RetirementStatementAmount>();
}
