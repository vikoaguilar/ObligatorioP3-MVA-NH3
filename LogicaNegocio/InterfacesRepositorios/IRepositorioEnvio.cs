using LogicaNegocio.EntidadesDominio;

namespace LogicaNegocio.InterfacesRepositorios;

public interface IRepositorioEnvio : IRepositorio<Envio>
{
    Envio BuscarEnvioPorTracking(int tracking);
    void FinalizarEnvio(int id);
}