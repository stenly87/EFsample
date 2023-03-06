using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class Curator
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Birthday { get; set; }

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
