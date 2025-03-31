namespace CasosUso.DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Documento { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }
    public RolDTO Rol { get; set; }
}