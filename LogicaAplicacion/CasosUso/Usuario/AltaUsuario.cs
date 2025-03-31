using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso;

public class AltaUsuario : IAltaUsuario
{
    IRepositorioUsuario RepoUsuario { get; set; }
    public void EjecutarAlta(UsuarioDTO dto)
    {
        throw new NotImplementedException();
    }
}