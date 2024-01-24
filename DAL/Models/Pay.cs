using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Pay
{
    /// <summary>
    /// شناسه پرداخت حقوق
    /// </summary>
    public Guid PayId { get; set; }

    /// <summary>
    /// شناسه حکم بازنشستگی
    /// </summary>
    public Guid? RetirementStatementId { get; set; }

    /// <summary>
    /// شناسه مستمری بگیر مرتبط
    /// </summary>
    public Guid? PensionaryId { get; set; }

    /// <summary>
    /// شماره حساب گیرنده حقوق
    /// </summary>
    public string PayAccount { get; set; } = null!;

    /// <summary>
    /// مبلغ بستانکار در این حقوق
    /// </summary>
    public decimal PayCreditAmount { get; set; }

    /// <summary>
    /// مبلغ بدهکار در این حقوق
    /// </summary>
    public decimal PayDebitAmount { get; set; }

    /// <summary>
    /// مبلغ کلی این حقوق
    /// </summary>
    public decimal PayAmount { get; set; }

    /// <summary>
    /// تاریخ شمسی پرداخت حقوق
    /// </summary>
    public string PaySolarDate { get; set; } = null!;

    /// <summary>
    /// تاریخ میلادی پرداخت حقوق
    /// </summary>
    public DateTime PayDate { get; set; }

    /// <summary>
    /// تاریخ شمسی تایید پرداخت حقوق
    /// </summary>
    public string? PayConfirmSolarDate { get; set; }

    /// <summary>
    /// تاریخ میلادی تایید پرداخت حقوق
    /// </summary>
    public DateTime? PayConfirmDate { get; set; }

    /// <summary>
    /// شناسه بازنشسته گیرنده حقوق
    /// </summary>
    public long? RetiredId { get; set; }

    /// <summary>
    /// شناسه وظیفه بگیر گیرنده حقوق
    /// </summary>
    public long? HeirId { get; set; }

    /// <summary>
    /// سال مالی پرداخت حقوق
    /// </summary>
    public int CurrentYearId { get; set; }

    /// <summary>
    /// شناسه ماه پرداخت حقوق
    /// </summary>
    public int CurrentMonthId { get; set; }

    /// <summary>
    /// شناسه کاربر ایجاد کننده
    /// </summary>
    public Guid InsertUserId { get; set; }

    /// <summary>
    /// زمان ایجاد
    /// </summary>
    public DateTime InsertTime { get; set; }

    /// <summary>
    /// شناسه آخرین کاربر ویرایش کننده
    /// </summary>
    public Guid? UpdateUserId { get; set; }

    /// <summary>
    /// زمان آخرین ویرایش
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    public virtual ICollection<PayItem> PayItems { get; set; } = new List<PayItem>();
}
