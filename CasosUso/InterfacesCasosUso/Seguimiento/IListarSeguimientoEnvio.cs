using CasosUso.DTOs;

namespace CasosUso.InterfacesCasosUso.Seguimiento;

public interface IListarSeguimientoEnvio
{
    List<SeguimientoDTO> ObtenerSeguimientoEnvio(int idEnvio);
}