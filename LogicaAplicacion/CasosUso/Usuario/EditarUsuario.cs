using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso;

public class EditarUsuario : IEditarUsuario
{
    IRepositorioUsuario RepoUsuario { get; set; }
    public void EjecutarEditar(UsuarioDTO dto)
    {
        throw new NotImplementedException();
    }
}