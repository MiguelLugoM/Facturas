public class Factura
{
    private DateOnly? fecha;
    private long numero;
    private double total;

    public Factura(DateOnly fecha, long numero, double total)
    {
        this.Fecha = fecha;
        this.Numero = numero;
        this.Total = total;
    }

    public Factura()
    {
        fecha = null;
        Numero = 0;
        Total = 0.0;
    }

    public DateOnly? Fecha { get => fecha; set => fecha = value; }
    public long Numero { get => numero; set => numero = value; }
    public double Total { get => total; set => total = value; }
}