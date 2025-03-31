using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAccesoDatos.Repositorios;

public class RepoUsuariosMemoria : IRepositorioUsuario
{
    // ACA IRAN LOS DATOS DE PRUEBA DE USUARIOS
    List<Usuario> ListaUsuarios = new List<Usuario>();
    int ultimoId = 0;
    
    public void Add(Usuario obj)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Usuario obj)
    {
        throw new NotImplementedException();
    }

    public List<Usuario> FindAll()
    {
        throw new NotImplementedException();
    }

    public Usuario FindById(int id)
    {
        throw new NotImplementedException();
    }
}