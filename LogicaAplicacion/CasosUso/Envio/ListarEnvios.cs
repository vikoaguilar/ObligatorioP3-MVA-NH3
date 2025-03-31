using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso.Envio;
using LogicaNegocio.InterfacesRepositorios;
namespace LogicaAplicacion.CasosUso.Envio;

public class ListarEnvios : IListarEnvios
{
    IRepositorioEnvio RepoEnvio { get; set; }
    public List<EnvioDTO> ObtenerListadoEnvios()
    {
        throw new NotImplementedException();
    }
}