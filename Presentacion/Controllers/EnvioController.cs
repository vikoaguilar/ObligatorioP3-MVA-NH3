using CasosUso.InterfacesCasosUso.Envio;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class EnvioController : Controller
    {
        public IAltaEnvio CUAltaEnvio { get; set; }
        public IBuscarEnvioPorId CUBuscarEnvioPorId { get; set; }
        public IBuscarEnvioPorTracking CUBuscarEnvioPorTracking { get; set; }
        public IFinalizarEnvio CUFinalizarEnvio { get; set; }
        public IListarEnvios CUListarEnvios { get; set; }

        public EnvioController(IAltaEnvio cuAltaEnvio, IBuscarEnvioPorId cuBuscarEnvioPorId,
            IBuscarEnvioPorTracking cuBuscarEnvioPorTracking, IFinalizarEnvio cuFinalizarEnvio,
            IListarEnvios cuListarEnvios)
        {
            CUAltaEnvio = cuAltaEnvio;
            CUBuscarEnvioPorId = cuBuscarEnvioPorId;
            CUBuscarEnvioPorTracking = cuBuscarEnvioPorTracking;
            CUFinalizarEnvio = cuFinalizarEnvio;
            CUListarEnvios = cuListarEnvios;
        }
        // GET: EnvioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EnvioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnvioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnvioController/Create
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

        // GET: EnvioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnvioController/Edit/5
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

        // GET: EnvioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnvioController/Delete/5
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
