using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmploymentType
{
    /// <summary>
    /// نوع استخدام
    /// </summary>
    public Guid EmploymentTypeId { get; set; }

    /// <summary>
    /// نوع استخدام
    /// </summary>
    public string EmploymentTypeName { get; set; } = null!;

    public int InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual ICollection<Pensionary> Pensionaries { get; set; } = new List<Pensionary>();
}
