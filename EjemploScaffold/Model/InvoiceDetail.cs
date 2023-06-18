using System;
using System.Collections.Generic;

namespace EjemploScaffold.Model;

public partial class InvoiceDetail
{
    public int? Id { get; set; }

    public int? InvoiceId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Total { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Product? Product { get; set; }
}
