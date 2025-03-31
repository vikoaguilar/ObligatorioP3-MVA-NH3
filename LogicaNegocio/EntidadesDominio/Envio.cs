namespace LogicaNegocio.EntidadesDominio;

public class Envio
{
    public int Id { get; set; }
    public string tracking { get; set; }
    public Usuario Empleado { get; set; }
    public Usuario Cliente { get; set; }
    public double Peso { get; set; }
    public Status Estado { get; set; }
    public List<Seguimiento> Seguimientos { get; set; }
}