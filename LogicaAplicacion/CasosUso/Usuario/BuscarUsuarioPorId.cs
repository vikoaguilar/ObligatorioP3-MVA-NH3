using CasosUso.InterfacesCasosUso;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso;

public class BuscarUsuarioPorId : IBuscarUsuarioPorId
{
    IRepositorioUsuario RepoUsuario { get; set; }
    public void BuscarUsuario(int id)
    {
        throw new NotImplementedException();
    }
}