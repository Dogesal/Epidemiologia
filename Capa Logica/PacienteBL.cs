using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Microsoft.EntityFrameworkCore;

namespace Capa_Logica
{
    public class PacienteBL
    {
        private readonly RepEpidemiologiaContext _dbcontext;
        public PacienteBL(RepEpidemiologiaContext dbcontext)
        {

            _dbcontext = dbcontext;

        }

        public IEnumerable<Paciente> ListPaciente() {

            try
            {
                return _dbcontext.Pacientes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        

        }

        public object AddPaciente(Paciente paciente)
        {
            try
            {
                // Agregar el paciente a la base de datos
                _dbcontext.Pacientes.Add(paciente);
                _dbcontext.SaveChanges();

                // Buscar el paciente recién agregado usando su ID generado automáticamente
                var pacien = _dbcontext.Pacientes
                    .Where(p => p.IdPaciente == paciente.IdPaciente) // Usamos el Id generado automáticamente  
                    .FirstOrDefault();

                // Verificar si el paciente existe
                if (pacien == null)
                {
                    throw new Exception("Paciente no encontrado después de ser agregado.");
                }

                // Retornar solo el Nombre y los Servicios del paciente
                return new { pacien.IdPaciente,pacien.NombrePaciente, pacien.Dni };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar paciente: {ex.Message}");
            }
        }

        public int AddPacienteID(Paciente paciente)
        {
            try
            {
                // Agregar el paciente a la base de datos
                _dbcontext.Pacientes.Add(paciente);
                _dbcontext.SaveChanges();

                // Buscar el paciente recién agregado usando su ID generado automáticamente
                var pacien = _dbcontext.Pacientes
                    .Where(p => p.IdPaciente == paciente.IdPaciente) // Usamos el Id generado automáticamente  
                    .FirstOrDefault();

                // Verificar si el paciente existe
                if (pacien == null)
                {
                    throw new Exception("Paciente no encontrado después de ser agregado.");
                }

                // Retornar solo el Nombre y los Servicios del paciente
                return pacien.IdPaciente;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar paciente: {ex.Message}");
            }
        }
        public object DeletePaciente(int id)
        {
            try
            {
                
                var paciente = _dbcontext.Pacientes.Find(id);
                if (paciente == null)
                {
                    throw new Exception($"No existe id");
                }
                _dbcontext.Pacientes.Remove(paciente);
                _dbcontext.SaveChanges();

                // Retornar solo el Nombre y los Servicios del paciente
                return new { paciente.NombrePaciente, paciente.Dni };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar paciente: {ex.Message}");
            }
        }

        public object EditPaciente(int id, Paciente _paciente)
        {
            try
            {
                // Buscar el paciente en la base de datos por ID
                var paciente = _dbcontext.Pacientes.Find(id);

                // Verificar si el paciente existe
                if (paciente == null)
                {
                    throw new Exception("Paciente no encontrado.");
                }

                // Asignar los valores del objeto _paciente al paciente encontrado
                paciente.NombrePaciente = _paciente.NombrePaciente;
                paciente.Edad = _paciente.Edad;
                paciente.Genero = _paciente.Genero;
                paciente.Dni = _paciente.Dni;
                paciente.Diagnostico = _paciente.Diagnostico;
                paciente.FechaIngreso = _paciente.FechaIngreso;

                // Guardar los cambios en la base de datos
                _dbcontext.SaveChanges();

                // Retornar solo el Nombre y Dni del paciente editado
                return new { paciente.NombrePaciente, paciente.Dni };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al editar paciente: {ex.Message}");
            }
        }

      
    }
}
