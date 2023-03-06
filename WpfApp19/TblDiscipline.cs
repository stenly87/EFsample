using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class TblDiscipline
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<CrossPrepodDiscipline> CrossPrepodDisciplines { get; } = new List<CrossPrepodDiscipline>();
}
