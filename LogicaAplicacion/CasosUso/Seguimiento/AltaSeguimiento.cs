using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso.Seguimiento;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso.Seguimiento;

public class AltaSeguimiento : IAltaSeguimiento
{
    IRepositorioSeguimiento RepoSeguimiento { get; set; }
    public void EjecutarAltaSeguimiento(SeguimientoDTO dto)
    {
        throw new NotImplementedException();
    }
}