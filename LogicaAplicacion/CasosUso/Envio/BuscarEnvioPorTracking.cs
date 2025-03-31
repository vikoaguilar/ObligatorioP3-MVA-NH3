using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso.Envio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso.Envio;

public class BuscarEnvioPorTracking : IBuscarEnvioPorTracking
{
    IRepositorioEnvio RepoEnvio { get; set; }
    public EnvioDTO ObtenerEnvioPorTracking(int tracking)
    {
        throw new NotImplementedException();
    }
}