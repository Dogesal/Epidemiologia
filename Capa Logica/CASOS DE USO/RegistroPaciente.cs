using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Entidad.RegistroPaciente;

namespace Capa_Logica.CASOS_DE_USO
{
    public class RegistroPaciente
    {
        private readonly RepEpidemiologiaContext _dbcontext;

        private readonly PacienteBL _pacienteBL;

        public RegistroPaciente(RepEpidemiologiaContext dbcontext , PacienteBL pacienteBL)
        {
            _dbcontext = dbcontext;
            _pacienteBL = pacienteBL;
        }


        public object AddRegistroPaciente(RegistroPacienteDTO registroPaciente) {

            int IDpaciente = _pacienteBL.AddPacienteID(registroPaciente.Paciente);

            registroPaciente.PacienteServicio.IdPaciente = IDpaciente;
            registroPaciente.PacienteServicio.IdServicio = registroPaciente.IdServicio;


            
            try
            {
                _dbcontext.PacienteServicios.Add(registroPaciente.PacienteServicio);
                _dbcontext.SaveChanges();

                // Retornar un objeto con los datos requeridos
                return new
                {
                    ID = registroPaciente.PacienteServicio.IdPacienteServicio,
                    fechaIngreso = registroPaciente.PacienteServicio.FechaIngreso // Opcional si necesitas devolver ambos
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el servicio: {ex.Message}");
            }
        }


    }
}
