using CasosUso.DTOs;

namespace CasosUso.InterfacesCasosUso;

public interface IListarUsuarios
{
    List<UsuarioDTO> ObtenerListadoUsuarios();
}