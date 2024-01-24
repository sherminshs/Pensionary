using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbGroupUser
{
    public string GroupUserId { get; set; } = null!;

    public string? FKUserId { get; set; }

    public string? FKGroupId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUserId { get; set; }

    public virtual TbGroup? FKGroup { get; set; }

    public virtual TbUser? FKUser { get; set; }
}
