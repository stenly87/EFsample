using System;
using System.Collections.Generic;

namespace WpfApp19;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PatronymicName { get; set; }

    public DateOnly? Birthday { get; set; }

    public int? GroupId { get; set; }

    public virtual Group? Group { get; set; }
}
