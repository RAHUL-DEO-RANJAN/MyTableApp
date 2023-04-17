using System;
using System.Collections.Generic;

namespace ClassLibrary.Data.Entities;

public partial class MyTable
{
    public int MyTableId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Contacts> Contacts { get; set; } = new List<Contacts>();
}
