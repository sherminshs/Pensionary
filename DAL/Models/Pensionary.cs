using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Pensionary
{
    public Guid PensionaryId { get; set; }

    public Guid? PersonId { get; set; }

    public Guid? ParentPersonId { get; set; }

    public Guid PensionaryStatusId { get; set; }

    public DateTime PensionaryStartdate { get; set; }

    public string PensionaryStartSolarDate { get; set; } = null!;

    public DateTime? PensionaryFinishdate { get; set; }

    public string? PensionaryFinishSolarDate { get; set; }

    public bool PensionaryIsActive { get; set; }

    public Guid? RelationshipWithParentId { get; set; }

    public Guid? EmploymentTypeId { get; set; }

    public int? LedgerCode { get; set; }

    public Guid? BankId { get; set; }

    public Guid? BankBranchId { get; set; }

    public string? AccountNo { get; set; }

    public double? InsuranceCoef { get; set; }

    public long? RetiredId { get; set; }

    public long? RelatedId { get; set; }

    public long? HeirId { get; set; }

    public long? PersonnelId { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual EmploymentType? EmploymentType { get; set; }

    public virtual Person? ParentPerson { get; set; }

    public virtual PensionaryStatus PensionaryStatus { get; set; } = null!;

    public virtual Person? Person { get; set; }

    public virtual ICollection<RetirementStatementRelated> RetirementStatementRelateds { get; set; } = new List<RetirementStatementRelated>();

    public virtual ICollection<RetirementStatement> RetirementStatements { get; set; } = new List<RetirementStatement>();
}
