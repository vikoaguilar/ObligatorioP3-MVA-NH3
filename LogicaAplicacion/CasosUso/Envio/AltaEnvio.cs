using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso.Envio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso.Envio;

public class AltaEnvio : IAltaEnvio
{
    IRepositorioEnvio RepoEnvio { get; set; }
    
    public void EjecutarAltaEnvio(EnvioDTO dto)
    {
        throw new NotImplementedException();
    }
}