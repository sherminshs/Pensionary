using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RetirementStatementItem
{
    /// <summary>
    /// آیتم حکم
    /// </summary>
    public Guid RetirementStatementItemId { get; set; }

    /// <summary>
    /// آیتم حکم
    /// </summary>
    public string RetirementStatementItemName { get; set; } = null!;

    /// <summary>
    /// این آیتم حکم از موارد حکم بازنشسته است نه حکم موطف و غیره
    /// </summary>
    public bool IsBasicItem { get; set; }

    /// <summary>
    /// این آیتم حکم در حال حاضر برای احکام جدید فعال است
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// این آیتم حکم مستقل نشان داده می شود و با حقوق مبنا جمع نمی شود
    /// </summary>
    public bool IsIndependentItem { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual ICollection<RetirementStatementAmount> RetirementStatementAmounts { get; set; } = new List<RetirementStatementAmount>();
}
