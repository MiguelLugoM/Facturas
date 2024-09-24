using System;
using System.Collections.Generic;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class Persona
{
    public string Codigo { get; set; } = null!;

    public string? Email { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Vendedor? Vendedor { get; set; }
}
