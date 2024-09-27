using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class Producto
{
    
    public string Codigo { get; set; } = null!;

    public string? Nombre { get; set; }

    public int? Stock { get; set; }

    public double? ValorUnitario { get; set; }

    public virtual ICollection<ProductosPorFactura> ProductosPorFacturas { get; set; } = new List<ProductosPorFactura>();
}
