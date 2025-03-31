using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso;
using LogicaNegocio.InterfacesRepositorios;

public class ListarUsuarios : IListarUsuarios
{
    IRepositorioUsuario RepoUsuario { get; set; }
    public List<UsuarioDTO> ObtenerListadoUsuarios()
    {
        throw new NotImplementedException();
    }
}