using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RetirementStatement
{
    public Guid RetirementStatementId { get; set; }

    public Guid PensionaryId { get; set; }

    public Guid? PensionaryStatusId { get; set; }

    public DateTime? RetirementStatementDate { get; set; }

    public string? RetirementStatementSolarDate { get; set; }

    public DateTime? RetirementStatementPreIssueDate { get; set; }

    public string? RetirementStatementPreIssueSolarDate { get; set; }

    public DateTime? RetirementStatementIssueDate { get; set; }

    public string? RetirementStatementIssueSolarDate { get; set; }

    public DateTime? RetirementStatementIssueConfirmDate { get; set; }

    public string? RetirementStatementIssueConfirmSolarDate { get; set; }

    public DateTime? RetirementStatementRunDate { get; set; }

    public string? RetirementStatementRunSolarDate { get; set; }

    public DateTime? RetirementStatementPayConfirmDate { get; set; }

    public string? RetirementStatementPayConfirmSolarDate { get; set; }

    public DateTime? RetirementStatementRedirectDate { get; set; }

    public string? RetirementStatementRedirectSolarDate { get; set; }

    /// <summary>
    /// تعداد وابستگان
    /// </summary>
    public int? RetirementStatementRelatedCount { get; set; }

    /// <summary>
    /// تعداد همسران
    /// </summary>
    public int? RetirementStatementSpouseCount { get; set; }

    public int? RetirementStatementSerial { get; set; }

    public string? RetirementStatementNo { get; set; }

    public string? RetirementStatementDesc { get; set; }

    public Guid? RetirementStatementTypeId { get; set; }

    public Guid? RetirementDocumentId { get; set; }

    /// <summary>
    /// این حکم آخرین حکم تایید شده بازنشسته است
    /// </summary>
    public bool RetirementStatementIsLast { get; set; }

    /// <summary>
    /// این بازنشسته فعلا حقوق نمی گیرد
    /// </summary>
    public bool? RetirementStatementIsLockedForPayment { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual Pensionary Pensionary { get; set; } = null!;

    public virtual PensionaryStatus? PensionaryStatus { get; set; }

    public virtual ICollection<RetirementStatementAmount> RetirementStatementAmounts { get; set; } = new List<RetirementStatementAmount>();

    public virtual ICollection<RetirementStatementRelated> RetirementStatementRelateds { get; set; } = new List<RetirementStatementRelated>();
}
