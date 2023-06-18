using System;
using System.Collections.Generic;

namespace EjemploScaffold.Model;

public partial class Invoice
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public DateTime? EmissionDate { get; set; }

    public decimal? Total { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public bool? Status { get; set; }

    public virtual Client? Client { get; set; }
}
