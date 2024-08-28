using System;
using System.Collections.Generic;

namespace DbFirst.Entities;

public partial class Operation
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? BookId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Student? Student { get; set; }
}
