namespace CasosUso.DTOs;

public class EnvioDTO
{
    public int Id { get; set; }
    public string tracking { get; set; }
    public UsuarioDTO Empleado { get; set; }
    public UsuarioDTO Cliente { get; set; }
    public double Peso { get; set; }
    public StatusDTO Estado { get; set; }
}