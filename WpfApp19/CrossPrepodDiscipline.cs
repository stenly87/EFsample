using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class CrossPrepodDiscipline
{
    public int Id { get; set; }

    public int? IdPrepod { get; set; }

    public int? IdDiscipline { get; set; }

    public int? DayOfWeek { get; set; }

    public virtual TblDiscipline? IdDisciplineNavigation { get; set; }

    public virtual TblPrepod? IdPrepodNavigation { get; set; }
}
