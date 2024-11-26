using Capa_Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capa_Entidad.Controllers
{
    public class PacienteController : Controller
    {

        private readonly PacienteBL _pacienteBL;

        public PacienteController(PacienteBL pacienteBL)
        {
            _pacienteBL = pacienteBL;
        }
        // GET: PacienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PacienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        public IActionResult listPaciente() {

            return new JsonResult(_pacienteBL.ListPaciente());

        }

        [HttpPost]
        public IActionResult AddPaciente([FromBody] Paciente paciente)
        {

            return new JsonResult(_pacienteBL.AddPaciente(paciente));


        }

        [HttpDelete]
        public IActionResult DeletePaciente(int id)
        {

            return new JsonResult(_pacienteBL.DeletePaciente(id));

        }

        [HttpPut]
        public IActionResult EditPaciente(int id,[FromBody] Paciente paciente)
        {

            return new JsonResult(_pacienteBL.EditPaciente(id, paciente));

        }
    }
}
