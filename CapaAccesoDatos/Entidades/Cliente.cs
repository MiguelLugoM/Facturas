public class Cliente : Persona
{
    private double credito;

    public Cliente(double credito)
    {
        this.credito = credito;
    }

    public Cliente()
    {
        credito = 0.0;
    }
    public double Credito { get => credito; set => credito = value; }
}