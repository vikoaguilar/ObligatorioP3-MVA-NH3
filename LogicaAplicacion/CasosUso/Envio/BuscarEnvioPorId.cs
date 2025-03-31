using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso.Envio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso.Envio;

public class BuscarEnvioPorId : IBuscarEnvioPorId
{
    IRepositorioEnvio RepoEnvio { get; set; }
    public EnvioDTO ObtenerEnvioPorId(int id)
    {
        throw new NotImplementedException();
    }
}