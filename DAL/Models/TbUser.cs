using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TbUser
{
    public string UserId { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? IsActive { get; set; }

    public string? FNameP { get; set; }

    public string? LNameP { get; set; }

    public string? Email { get; set; }

    public bool? Sex { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public int? IsDelete { get; set; }

    public DateTime? EditDate { get; set; }

    public string? EditUser { get; set; }

    public virtual ICollection<TbGroupUser> TbGroupUsers { get; set; } = new List<TbGroupUser>();
}
