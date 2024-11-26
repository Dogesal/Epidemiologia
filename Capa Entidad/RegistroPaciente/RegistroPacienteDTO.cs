using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad.RegistroPaciente
{
    public class RegistroPacienteDTO
    {
        public Paciente Paciente { get; set; }
        public int IdServicio { get; set; }
        public PacienteServicio PacienteServicio { get; set; }
    }
}
