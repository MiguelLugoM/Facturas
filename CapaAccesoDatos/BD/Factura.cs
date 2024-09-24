using System;
using System.Collections.Generic;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class Factura
{
    public long Numero { get; set; }

    public DateOnly? Fecha { get; set; }

    public double? Total { get; set; }

    public string? CodigoCliente { get; set; }

    public virtual Cliente? CodigoClienteNavigation { get; set; }

    public virtual ICollection<ProductosPorFactura> ProductosPorFacturas { get; set; } = new List<ProductosPorFactura>();
}
