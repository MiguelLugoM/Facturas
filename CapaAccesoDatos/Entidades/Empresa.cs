public class Empresa
{
    private string codigo;
    private string nombre;

    public Empresa(string codigo, string nombre)
    {
        this.codigo = codigo;
        this.nombre = nombre;
    }

    public Empresa()
    {
        codigo = string.Empty;
        nombre = string.Empty;
    }

    public string Codigo { get => codigo; set => codigo = value; }
    public string Nombre { get => nombre; set => nombre = value; }
}