using CasosUso.DTOs;

namespace CasosUso.InterfacesCasosUso.Envio;

public interface IBuscarEnvioPorId
{
    EnvioDTO ObtenerEnvioPorId(int id);
}