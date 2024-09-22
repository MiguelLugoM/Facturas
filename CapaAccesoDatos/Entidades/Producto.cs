public class Producto
{
    private string codigo;
    private string nombre;
    private int stock;
    private double valorUnitario;

    public Producto(string codigo, string nombre, int stock, double valorUnitario)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.stock = stock;
        this.valorUnitario = valorUnitario;
    }

    public Producto()
    {
        codigo = string.Empty;
        nombre = string.Empty;
        stock = 0;
        valorUnitario = 0.0;
    }

    public string Codigo { get => codigo; set => codigo = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Stock { get => stock; set => stock = value; }
    public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
}