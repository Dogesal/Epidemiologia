using Capa_Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capa_Entidad.Controllers
{
    public class ServicioController : Controller
    {

        private readonly ServicioBL _servicioBL;

        public ServicioController(ServicioBL servicioBL) { 
        _servicioBL = servicioBL;
        }

        // GET: ServicioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServicioController/Details/5
        public IActionResult listarServicios() {

            return new JsonResult(_servicioBL.ListServicio());
            
        }

        [HttpPost]
        public IActionResult AddServicios([FromBody] Servicio servicio)
        {

            return new JsonResult(_servicioBL.AddServicio(servicio));

        }

        [HttpDelete]
        public IActionResult DeleteServicios(int id)
        {

            return new JsonResult(_servicioBL.DeleteServicio(id));

        }

    }
}
