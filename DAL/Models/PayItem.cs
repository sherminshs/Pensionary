using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayItem
{
    /// <summary>
    /// شناسه آیتم فیش حقوقی
    /// </summary>
    public Guid PayItemId { get; set; }

    /// <summary>
    /// مبلغ پرداخت آیتم فیش حقوقی
    /// </summary>
    public decimal PayItemCreditAmount { get; set; }

    /// <summary>
    /// مبلغ کسر آیتم فیش حقوقی
    /// </summary>
    public decimal PayItemDebitAmount { get; set; }

    /// <summary>
    /// مبلغ کلی آیتم فیش حقوقی
    /// </summary>
    public decimal PayItemAmount { get; set; }

    /// <summary>
    /// زمان شمسی پرداخت آیتم فیش حقوقی
    /// </summary>
    public string? PayItemSolarDate { get; set; }

    /// <summary>
    /// زمان میلادی پرداخت آیتم فیش حقوقی
    /// </summary>
    public DateTime? PayItemDate { get; set; }

    /// <summary>
    /// مباغ مانده آیتم فیش حقوقی
    /// </summary>
    public decimal? PayItemRemainedAmount { get; set; }

    /// <summary>
    /// شناسه پرداخت حقوق
    /// </summary>
    public Guid PayId { get; set; }

    /// <summary>
    /// شناسه نوع آیتم فیش حقوقی
    /// </summary>
    public Guid PayItemTypeId { get; set; }

    /// <summary>
    /// شناسه تسهیلات مرتبط
    /// </summary>
    public Guid? FacilityId { get; set; }

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

    public virtual Pay Pay { get; set; } = null!;

    public virtual PayItemType PayItemType { get; set; } = null!;
}
