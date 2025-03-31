namespace LogicaNegocio.EntidadesDominio;

public class Seguimiento
{
    public int Id { get; set; }
    public string Comentario { get; set; }
    public Usuario Empleado { get; set; }
    public DateTime Fecha { get; set; }
}