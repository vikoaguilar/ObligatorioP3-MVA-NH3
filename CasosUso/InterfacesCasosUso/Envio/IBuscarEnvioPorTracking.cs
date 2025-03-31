using CasosUso.DTOs;

namespace CasosUso.InterfacesCasosUso.Envio;

public interface IBuscarEnvioPorTracking
{
    EnvioDTO ObtenerEnvioPorTracking(int tracking);
}