using System;
using System.Collections.Generic;

namespace DbFirst.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SchoolNumber { get; set; }

    public int? Gender { get; set; }

    public DateOnly? BirthDay { get; set; }

    public string? PhoneNumber { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();
}
