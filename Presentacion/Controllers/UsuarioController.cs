using CasosUso.InterfacesCasosUso;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class UsuarioController : Controller
    {
        public IAltaUsuario CUAltaUsuario { get; set; }
        public IBajaUsuario CUBajaUsuario { get; set; }
        public IBuscarUsuarioPorId CUBuscarUsuarioPorId { get; set; }
        public IEditarUsuario CUEditarUsuario { get; set; }
        public IListarUsuarios CUListarUsuarios { get; set; }

        public UsuarioController(IAltaUsuario cuAltaUsuario, IBajaUsuario cuBajaUsuario, IBuscarUsuarioPorId cuBuscarUsuarioPorId, IEditarUsuario cuEditarUsuario, IListarUsuarios cuListarUsuarios)
        {
            CUAltaUsuario = cuAltaUsuario;
            CUBajaUsuario = cuBajaUsuario;
            CUBuscarUsuarioPorId = cuBuscarUsuarioPorId;
            CUEditarUsuario = cuEditarUsuario;
            CUListarUsuarios = cuListarUsuarios;
        }
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
