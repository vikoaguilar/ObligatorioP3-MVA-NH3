namespace CasosUso.DTOs;

public class SeguimientoDTO
{
    public int Id { get; set; }
    public string Comentario { get; set; }
    public EnvioDTO Envio { get; set; }
    public UsuarioDTO Empleado { get; set; }
    public DateTime Fecha { get; set; }
}