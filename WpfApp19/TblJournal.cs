using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class TblJournal
{
    public int Id { get; set; }

    public int? DisciplineId { get; set; }

    public int? StudentId { get; set; }

    public DateOnly? Day { get; set; }

    public string? Value { get; set; }
}
