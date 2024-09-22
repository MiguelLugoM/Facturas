public class ProductoPorFacturas
{
    private int cantidad;
    private double subtotal;

    public ProductoPorFacturas(int cantidad, double subtotal)
    {
        this.Cantidad = cantidad;
        this.Subtotal = subtotal;
    }

    public ProductoPorFacturas()
    {
        Cantidad = 0;
        Subtotal = 0.0;
    }

    public int Cantidad { get => cantidad; set => cantidad = value; }
    public double Subtotal { get => subtotal; set => subtotal = value; }
}