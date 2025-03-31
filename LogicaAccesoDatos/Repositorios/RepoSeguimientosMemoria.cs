using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAccesoDatos.Repositorios;

public class RepoSeguimientosMemoria : IRepositorioSeguimiento
{
    List<Seguimiento> ListaSeguimientos = new List<Seguimiento>();
    int ultimoId = 0;
    public void Add(Seguimiento obj)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Seguimiento obj)
    {
        throw new NotImplementedException();
    }

    public List<Seguimiento> FindAll()
    {
        throw new NotImplementedException();
    }

    public Seguimiento FindById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Seguimiento> ListarSeguimientoEnvio(int idEnvio)
    {
        throw new NotImplementedException();
    }
}