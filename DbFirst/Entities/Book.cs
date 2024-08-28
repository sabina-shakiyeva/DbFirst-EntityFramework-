using System;
using System.Collections.Generic;

namespace DbFirst.Entities;

public partial class Book
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? PageCount { get; set; }

    public int? AuthorId { get; set; }

    public int? BookTypeId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Author? Author { get; set; }

    public virtual BookType? BookType { get; set; }

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();


    public override string ToString()
   => $"Name:{Name}-Page:{PageCount}";
}
