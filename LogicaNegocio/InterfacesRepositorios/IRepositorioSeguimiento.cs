using LogicaNegocio.EntidadesDominio;

namespace LogicaNegocio.InterfacesRepositorios;

public interface IRepositorioSeguimiento : IRepositorio<Seguimiento>
{
    List<Seguimiento> ListarSeguimientoEnvio(int idEnvio);
}