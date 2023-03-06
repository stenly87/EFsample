using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class Special
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
