using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbItem
{
    public string ItemId { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? Url { get; set; }

    public int? ItemStaus { get; set; }

    public string? ClassName { get; set; }

    public virtual ICollection<TbGroupItem> TbGroupItems { get; set; } = new List<TbGroupItem>();
}
