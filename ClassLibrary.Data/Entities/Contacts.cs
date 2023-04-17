using System;
using System.Collections.Generic;

namespace ClassLibrary.Data.Entities;

public partial class Contacts
{
    public int ContactsId { get; set; }

    public int? MyTableId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public virtual MyTable? MyTable { get; set; }
}
