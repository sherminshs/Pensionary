using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbGroupItem
{
    public string GroupItemId { get; set; } = null!;

    public string? FKItemId { get; set; }

    public string? FKGroupId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUserId { get; set; }

    public virtual TbGroup? FKGroup { get; set; }

    public virtual TbItem? FKItem { get; set; }
}
