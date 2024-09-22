public class Vendedor : Persona
{
    private int carne;
    private string direccion;

    public Vendedor(int carne, string direccion)
    {
        this.carne = carne;
        this.direccion = direccion;
    }
    public Vendedor()
    {
        carne = 0;
        direccion = string.Empty;
    }

    public int Carne { get => carne; set => carne = value; }
    public string Direccion { get => direccion; set => direccion = value; }

}