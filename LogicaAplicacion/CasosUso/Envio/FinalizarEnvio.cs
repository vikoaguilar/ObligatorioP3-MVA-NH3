using CasosUso.InterfacesCasosUso.Envio;
using LogicaNegocio.InterfacesRepositorios;
namespace LogicaAplicacion.CasosUso.Envio;

public class FinalizarEnvio : IFinalizarEnvio
{
    IRepositorioEnvio RepoEnvio { get; set; }
    public void EjecutarFinalizarEnvio(int id)
    {
        throw new NotImplementedException();
    }
}