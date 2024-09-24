using System;
using System.Collections.Generic;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class Cliente
{
    public string Codigo { get; set; } = null!;

    public double? Credito { get; set; }

    public string? CodigoEmpresa { get; set; }

    public virtual Empresa? CodigoEmpresaNavigation { get; set; }

    public virtual Persona CodigoNavigation { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
