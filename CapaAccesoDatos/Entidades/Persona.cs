public class Persona
{
    private string codigo;
    private string email;
    private string nombre;
    private string telefono;

    public Persona(string codigo, string email, string nombre, string telefono)
    {
        this.codigo = codigo;
        this.email = email;
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public Persona()
    {
        codigo = string.Empty;
        email = string.Empty;
        nombre = string.Empty;
        telefono = string.Empty;
    }

    public string Codigo { get => codigo; set => codigo = value; }
    public string Email { get => email; set => email = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
}