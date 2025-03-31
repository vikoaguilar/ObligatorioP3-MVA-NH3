namespace LogicaNegocio.EntidadesDominio;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Documento { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }
    public Rol Rol { get; set; }
}