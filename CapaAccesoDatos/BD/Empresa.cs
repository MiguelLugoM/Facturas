using System;
using System.Collections.Generic;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class Empresa
{
    public string Codigo { get; set; } = null!;

    public string? Nombre { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
