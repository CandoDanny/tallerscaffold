using System;
using System.Collections.Generic;

namespace EjemploScaffold.Model;

public partial class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Address { get; set; }

    public string? TelephoneNumber { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
