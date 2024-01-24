using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PensionaryStatus
{
    /// <summary>
    /// وضعیت مستمری بگیر
    /// </summary>
    public Guid PensionaryStatusId { get; set; }

    /// <summary>
    /// وضعیت مستمری بگیر
    /// </summary>
    public string PensionaryStatusName { get; set; } = null!;

    /// <summary>
    /// R=retired,L=related,H=heir,P=personnel  دسته بندی وضعیت مستمری بگیر
    /// </summary>
    public string PensionayStatusCategory { get; set; } = null!;

    /// <summary>
    ///  این وضعیت مستمری بگیری حقوق دریافت نمی کند
    /// </summary>
    public bool PensionaryStatusIsLockedForPayment { get; set; }

    /// <summary>
    /// این وضعیت مستمری بگیر برای فوتی هاست
    /// </summary>
    public bool PensionaryStatusIsDead { get; set; }

    /// <summary>
    /// این وضعیت مستمری بگیر اول می آید
    /// </summary>
    public bool PensionaryStatusIsFirst { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual ICollection<Pensionary> Pensionaries { get; set; } = new List<Pensionary>();

    public virtual ICollection<RetirementStatement> RetirementStatements { get; set; } = new List<RetirementStatement>();
}
