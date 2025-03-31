using CasosUso.InterfacesCasosUso;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso;

public class BajaUsuario : IBajaUsuario
{
    IRepositorioUsuario RepoUsuario { get; set; }
    public void EjecutarBaja(int id)
    {
        throw new NotImplementedException();
    }
}