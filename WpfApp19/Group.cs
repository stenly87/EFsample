using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class Group
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Year { get; set; }

    public int? CuratorId { get; set; }

    public int? SpecialId { get; set; }

    public virtual Curator? Curator { get; set; }

    public virtual Special? Special { get; set; }

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
