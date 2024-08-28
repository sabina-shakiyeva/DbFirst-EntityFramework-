using System;
using System.Collections.Generic;

namespace DbFirst.Entities;

public partial class BookType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
