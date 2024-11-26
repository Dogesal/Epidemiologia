using Capa_Entidad;
using Capa_Entidad.RegistroPaciente;
using Capa_Logica;
using Capa_Logica.CASOS_DE_USO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Epidemiologia.Controllers
{
    public class RegistroPacienteController : Controller
    {
        private readonly RegistroPaciente _registroPaciente;

        public RegistroPacienteController(RegistroPaciente registroPaciente)
        {
            _registroPaciente = registroPaciente;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRegistroPaciente([FromBody] RegistroPacienteDTO registroPaciente )
        {

            return new JsonResult(_registroPaciente.AddRegistroPaciente(registroPaciente));

        }
    }
}
