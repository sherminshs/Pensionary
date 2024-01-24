using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbGroup
{
    public string GroupId { get; set; } = null!;

    public string? GroupName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUserId { get; set; }

    public DateTime? EditDate { get; set; }

    public string? EditUserId { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual ICollection<TbGroupItem> TbGroupItems { get; set; } = new List<TbGroupItem>();

    public virtual ICollection<TbGroupUser> TbGroupUsers { get; set; } = new List<TbGroupUser>();
}
