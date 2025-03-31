using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso.Seguimiento;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso.Seguimiento;

public class ListarSeguimientoEnvio : IListarSeguimientoEnvio
{
    IRepositorioSeguimiento RepoSeguimiento { get; set; }
    public List<SeguimientoDTO> ObtenerSeguimientoEnvio(int idEnvio)
    {
        throw new NotImplementedException();
    }
}