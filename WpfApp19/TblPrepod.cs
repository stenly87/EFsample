using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class TblPrepod
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<CrossPrepodDiscipline> CrossPrepodDisciplines { get; } = new List<CrossPrepodDiscipline>();
}
