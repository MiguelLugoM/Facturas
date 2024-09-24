using System;
using System.Collections.Generic;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class ProductosPorFactura
{
    public long NumeroFactura { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public int? Cantidad { get; set; }

    public double? Subtotal { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;

    public virtual Factura NumeroFacturaNavigation { get; set; } = null!;
}
