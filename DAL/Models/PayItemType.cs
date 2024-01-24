using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayItemType
{
    /// <summary>
    /// شناسه نوع آیتم حقوقی
    /// </summary>
    public Guid PayItemTypeId { get; set; }

    /// <summary>
    /// نام نوع آیتم حقوقی
    /// </summary>
    public string PayItemTypeName { get; set; } = null!;

    /// <summary>
    /// نوع آیتم حقوقی فعال است
    /// </summary>
    public bool? PayItemTypeIsActive { get; set; }

    /// <summary>
    /// نوع آیتم حقوقی پرداخت است
    /// </summary>
    public bool PayItemTypeIsCredit { get; set; }

    /// <summary>
    /// این آیتم مبنای محاسبات بیمه است
    /// </summary>
    public bool PayItemTypeIsInsuranceBase { get; set; }

    /// <summary>
    /// شناسه نوع تسهیلات مرتبط با این آیتم
    /// </summary>
    public Guid? FacilityTypeId { get; set; }

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
