using System;
using System.Collections.Generic;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class Vendedor
{
    public string Codigo { get; set; } = null!;

    public int? Carnet { get; set; }

    public string? Direccion { get; set; }

    public virtual Persona CodigoNavigation { get; set; } = null!;
}
