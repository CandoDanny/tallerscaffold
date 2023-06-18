using System;
using System.Collections.Generic;

namespace EjemploScaffold.Model;

public partial class Product
{
    public int Id { get; set; }

    public byte[]? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }
}
