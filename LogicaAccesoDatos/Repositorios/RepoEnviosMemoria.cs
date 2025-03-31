using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAccesoDatos.Repositorios;

public class RepoEnviosMemoria : IRepositorioEnvio
{
    List<Envio> ListaEnvios = new List<Envio>();
    int ultimoId = 0;
    public void Add(Envio obj)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Envio obj)
    {
        throw new NotImplementedException();
    }

    public List<Envio> FindAll()
    {
        throw new NotImplementedException();
    }

    public Envio FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Envio BuscarEnvioPorTracking(int tracking)
    {
        throw new NotImplementedException();
    }

    public void FinalizarEnvio(int id)
    {
        throw new NotImplementedException();
    }
}